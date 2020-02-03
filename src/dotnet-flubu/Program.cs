﻿using System;
using System.Threading;
using DotNet.Cli.Flubu.Infrastructure;
using FlubuCore.Commanding;
using FlubuCore.Context;
using FlubuCore.Infrastructure;
using FlubuCore.Scripting;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DotNet.Cli.Flubu
{
    public static class Program
    {
        private static readonly IServiceCollection Services = new ServiceCollection();

        private static IServiceProvider _provider;

        private static bool _cleanUpPerformed = false;

        private static volatile bool _wait = false;

        public static int Main(string[] args)
        {
            if (args == null)
            {
                args = new string[0];
            }

            IServiceCollection serv = new ServiceCollection();

            serv.AddScriptAnalyzers()
                .AddCoreComponents()
                .AddCommandComponents(false)
                .AddLogging()
                .AddScriptAnalyzers();

            Services
                .AddCommandComponentsWithArguments(args, serv)
                .AddLogging()
                .AddCoreComponents()
                .AddScriptAnalyzers()
                .AddTasks();

            var prov = serv.BuildServiceProvider();

            IScriptProvider scriptProvider = prov.GetRequiredService<IScriptProvider>();
            CommandArguments commandArguments = prov.GetRequiredService<CommandArguments>();

            var script = scriptProvider.GetBuildScriptAsync(commandArguments).Result;
            script.ConfigureServices(Services);
            _provider = Services.BuildServiceProvider();

            ILoggerFactory factory = _provider.GetRequiredService<ILoggerFactory>();
            factory.AddProvider(new FlubuLoggerProvider());
            var cmdApp = _provider.GetRequiredService<CommandLineApplication>();
            ICommandExecutor executor = _provider.GetRequiredService<ICommandExecutor>();

            executor.FlubuHelpText = cmdApp.GetHelpText();
            Console.CancelKeyPress += OnCancelKeyPress;
            var result = executor.ExecuteAsync().Result;

            while (_wait)
            {
                Thread.Sleep(250);
            }

            return result;
        }

        private static void OnCancelKeyPress(object sender, ConsoleCancelEventArgs eventArgs)
        {
            if (!_cleanUpPerformed && CleanUpStore.TaskCleanUpActions?.Count > 0)
            {
                _wait = true;
                Console.WriteLine($"Performing clean up actions:");
                var taskSession = _provider.GetService<IFlubuSession>();
                foreach (var cleanUpAction in CleanUpStore.TaskCleanUpActions)
                {
                    cleanUpAction.Invoke(taskSession);
                    Console.WriteLine($"Finished performing clean up actions.");
                }

                _wait = false;
            }
        }
    }
}
