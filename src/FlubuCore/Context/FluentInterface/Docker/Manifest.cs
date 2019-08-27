
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Docker.Manifest;

namespace FlubuCore.Context.FluentInterface.Docker
{
    public class Manifest
    {  
        
            public DockerManifestAnnotateTask ManifestAnnotate(string manifest_list ,  string manifest)
            {
                return new DockerManifestAnnotateTask(manifest_list,  manifest);
            }

            public DockerManifestCreateTask ManifestCreate(string manifest_list ,  params string[] manifest)
            {
                return new DockerManifestCreateTask(manifest_list,  manifest);
            }

            public DockerManifestInspectTask ManifestInspect(string manifest_list,  string manifest)
            {
                return new DockerManifestInspectTask(manifest_list,  manifest);
            }

            public DockerManifestPushTask ManifestPush(string manifest_list)
            {
                return new DockerManifestPushTask(manifest_list);
            }
        
    }
}
