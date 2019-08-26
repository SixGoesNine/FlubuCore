
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerRunTask : ExternalProcessTaskBase<int, DockerRunTask>
     {
        private string _image;
private string _command;
private string[] _arg;

        
        public DockerRunTask(string image,  string command = null,  params string[] arg)
        {
            ExecutablePath = "docker";
            WithArguments("run");
_image = image;
_command = command;
_arg = arg;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add a custom host-to-IP mapping (host:ip)
        /// </summary>
        [ArgKey("--add-host")]
        public DockerRunTask AddHost(string addHost)
        {
            WithArgumentsKeyFromAttribute(addHost.ToString());
            return this;
        }

        /// <summary>
        /// Attach to STDIN, STDOUT or STDERR
        /// </summary>
        [ArgKey("--attach")]
        public DockerRunTask Attach(string attach)
        {
            WithArgumentsKeyFromAttribute(attach.ToString());
            return this;
        }

        /// <summary>
        /// Block IO (relative weight), between 10 and 1000, or 0 to disable (default 0)

        /// </summary>
        [ArgKey("--blkio-weight")]
        public DockerRunTask BlkioWeight(string blkioWeight)
        {
            WithArgumentsKeyFromAttribute(blkioWeight.ToString());
            return this;
        }

        /// <summary>
        /// Block IO weight (relative device weight)
        /// </summary>
        [ArgKey("--blkio-weight-device")]
        public DockerRunTask BlkioWeightDevice(string blkioWeightDevice)
        {
            WithArgumentsKeyFromAttribute(blkioWeightDevice.ToString());
            return this;
        }

        /// <summary>
        /// Add Linux capabilities
        /// </summary>
        [ArgKey("--cap-add")]
        public DockerRunTask CapAdd(string capAdd)
        {
            WithArgumentsKeyFromAttribute(capAdd.ToString());
            return this;
        }

        /// <summary>
        /// Drop Linux capabilities
        /// </summary>
        [ArgKey("--cap-drop")]
        public DockerRunTask CapDrop(string capDrop)
        {
            WithArgumentsKeyFromAttribute(capDrop.ToString());
            return this;
        }

        /// <summary>
        /// Optional parent cgroup for the container
        /// </summary>
        [ArgKey("--cgroup-parent")]
        public DockerRunTask CgroupParent(string cgroupParent)
        {
            WithArgumentsKeyFromAttribute(cgroupParent.ToString());
            return this;
        }

        /// <summary>
        /// Write the container ID to the file
        /// </summary>
        [ArgKey("--cidfile")]
        public DockerRunTask Cidfile(string cidfile)
        {
            WithArgumentsKeyFromAttribute(cidfile.ToString());
            return this;
        }

        /// <summary>
        /// CPU count (Windows only)
        /// </summary>
        [ArgKey("--cpu-count")]
        public DockerRunTask CpuCount(long cpuCount)
        {
            WithArgumentsKeyFromAttribute(cpuCount.ToString());
            return this;
        }

        /// <summary>
        /// CPU percent (Windows only)
        /// </summary>
        [ArgKey("--cpu-percent")]
        public DockerRunTask CpuPercent(long cpuPercent)
        {
            WithArgumentsKeyFromAttribute(cpuPercent.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU CFS (Completely Fair Scheduler) period
        /// </summary>
        [ArgKey("--cpu-period")]
        public DockerRunTask CpuPeriod(long cpuPeriod)
        {
            WithArgumentsKeyFromAttribute(cpuPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU CFS (Completely Fair Scheduler) quota
        /// </summary>
        [ArgKey("--cpu-quota")]
        public DockerRunTask CpuQuota(long cpuQuota)
        {
            WithArgumentsKeyFromAttribute(cpuQuota.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU real-time period in microseconds
        /// </summary>
        [ArgKey("--cpu-rt-period")]
        public DockerRunTask CpuRtPeriod(long cpuRtPeriod)
        {
            WithArgumentsKeyFromAttribute(cpuRtPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU real-time runtime in microseconds
        /// </summary>
        [ArgKey("--cpu-rt-runtime")]
        public DockerRunTask CpuRtRuntime(long cpuRtRuntime)
        {
            WithArgumentsKeyFromAttribute(cpuRtRuntime.ToString());
            return this;
        }

        /// <summary>
        /// CPU shares (relative weight)
        /// </summary>
        [ArgKey("--cpu-shares")]
        public DockerRunTask CpuShares(long cpuShares)
        {
            WithArgumentsKeyFromAttribute(cpuShares.ToString());
            return this;
        }

        /// <summary>
        /// Number of CPUs
        /// </summary>
        [ArgKey("--cpus")]
        public DockerRunTask Cpus(decimal cpus)
        {
            WithArgumentsKeyFromAttribute(cpus.ToString());
            return this;
        }

        /// <summary>
        /// CPUs in which to allow execution (0-3, 0,1)
        /// </summary>
        [ArgKey("--cpuset-cpus")]
        public DockerRunTask CpusetCpus(string cpusetCpus)
        {
            WithArgumentsKeyFromAttribute(cpusetCpus.ToString());
            return this;
        }

        /// <summary>
        /// MEMs in which to allow execution (0-3, 0,1)
        /// </summary>
        [ArgKey("--cpuset-mems")]
        public DockerRunTask CpusetMems(string cpusetMems)
        {
            WithArgumentsKeyFromAttribute(cpusetMems.ToString());
            return this;
        }

        /// <summary>
        /// Run container in background and print container ID
        /// </summary>
        [ArgKey("--detach")]
        public DockerRunTask Detach()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Override the key sequence for detaching a container
        /// </summary>
        [ArgKey("--detach-keys")]
        public DockerRunTask DetachKeys(string detachKeys)
        {
            WithArgumentsKeyFromAttribute(detachKeys.ToString());
            return this;
        }

        /// <summary>
        /// Add a host device to the container
        /// </summary>
        [ArgKey("--device")]
        public DockerRunTask Device(string device)
        {
            WithArgumentsKeyFromAttribute(device.ToString());
            return this;
        }

        /// <summary>
        /// Add a rule to the cgroup allowed devices list
        /// </summary>
        [ArgKey("--device-cgroup-rule")]
        public DockerRunTask DeviceCgroupRule(string deviceCgroupRule)
        {
            WithArgumentsKeyFromAttribute(deviceCgroupRule.ToString());
            return this;
        }

        /// <summary>
        /// Limit read rate (bytes per second) from a device
        /// </summary>
        [ArgKey("--device-read-bps")]
        public DockerRunTask DeviceReadBps(string deviceReadBps)
        {
            WithArgumentsKeyFromAttribute(deviceReadBps.ToString());
            return this;
        }

        /// <summary>
        /// Limit read rate (IO per second) from a device
        /// </summary>
        [ArgKey("--device-read-iops")]
        public DockerRunTask DeviceReadIops(string deviceReadIops)
        {
            WithArgumentsKeyFromAttribute(deviceReadIops.ToString());
            return this;
        }

        /// <summary>
        /// Limit write rate (bytes per second) to a device
        /// </summary>
        [ArgKey("--device-write-bps")]
        public DockerRunTask DeviceWriteBps(string deviceWriteBps)
        {
            WithArgumentsKeyFromAttribute(deviceWriteBps.ToString());
            return this;
        }

        /// <summary>
        /// Limit write rate (IO per second) to a device
        /// </summary>
        [ArgKey("--device-write-iops")]
        public DockerRunTask DeviceWriteIops(string deviceWriteIops)
        {
            WithArgumentsKeyFromAttribute(deviceWriteIops.ToString());
            return this;
        }

        /// <summary>
        /// Skip image verification
        /// </summary>
        [ArgKey("--disable-content-trust")]
        public DockerRunTask DisableContentTrust()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Set custom DNS servers
        /// </summary>
        [ArgKey("--dns")]
        public DockerRunTask Dns(string dns)
        {
            WithArgumentsKeyFromAttribute(dns.ToString());
            return this;
        }

        /// <summary>
        /// Set DNS options
        /// </summary>
        [ArgKey("--dns-opt")]
        public DockerRunTask DnsOpt(string dnsOpt)
        {
            WithArgumentsKeyFromAttribute(dnsOpt.ToString());
            return this;
        }

        /// <summary>
        /// Set DNS options
        /// </summary>
        [ArgKey("--dns-option")]
        public DockerRunTask DnsOption(string dnsOption)
        {
            WithArgumentsKeyFromAttribute(dnsOption.ToString());
            return this;
        }

        /// <summary>
        /// Set custom DNS search domains
        /// </summary>
        [ArgKey("--dns-search")]
        public DockerRunTask DnsSearch(string dnsSearch)
        {
            WithArgumentsKeyFromAttribute(dnsSearch.ToString());
            return this;
        }

        /// <summary>
        /// Container NIS domain name
        /// </summary>
        [ArgKey("--domainname")]
        public DockerRunTask Domainname(string domainname)
        {
            WithArgumentsKeyFromAttribute(domainname.ToString());
            return this;
        }

        /// <summary>
        /// Overwrite the default ENTRYPOINT of the image
        /// </summary>
        [ArgKey("--entrypoint")]
        public DockerRunTask Entrypoint(string entrypoint)
        {
            WithArgumentsKeyFromAttribute(entrypoint.ToString());
            return this;
        }

        /// <summary>
        /// Set environment variables
        /// </summary>
        [ArgKey("--env")]
        public DockerRunTask Env(string env)
        {
            WithArgumentsKeyFromAttribute(env.ToString());
            return this;
        }

        /// <summary>
        /// Read in a file of environment variables
        /// </summary>
        [ArgKey("--env-file")]
        public DockerRunTask EnvFile(string envFile)
        {
            WithArgumentsKeyFromAttribute(envFile.ToString());
            return this;
        }

        /// <summary>
        /// Expose a port or a range of ports
        /// </summary>
        [ArgKey("--expose")]
        public DockerRunTask Expose(string expose)
        {
            WithArgumentsKeyFromAttribute(expose.ToString());
            return this;
        }

        /// <summary>
        /// GPU devices to add to the container ('all' to pass all GPUs)
        /// </summary>
        [ArgKey("--gpus")]
        public DockerRunTask Gpus(string gpus)
        {
            WithArgumentsKeyFromAttribute(gpus.ToString());
            return this;
        }

        /// <summary>
        /// Add additional groups to join
        /// </summary>
        [ArgKey("--group-add")]
        public DockerRunTask GroupAdd(string groupAdd)
        {
            WithArgumentsKeyFromAttribute(groupAdd.ToString());
            return this;
        }

        /// <summary>
        /// Command to run to check health
        /// </summary>
        [ArgKey("--health-cmd")]
        public DockerRunTask HealthCmd(string healthCmd)
        {
            WithArgumentsKeyFromAttribute(healthCmd.ToString());
            return this;
        }

        /// <summary>
        /// Time between running the check (ms|s|m|h) (default 0s)
        /// </summary>
        [ArgKey("--health-interval")]
        public DockerRunTask HealthInterval(string healthInterval)
        {
            WithArgumentsKeyFromAttribute(healthInterval.ToString());
            return this;
        }

        /// <summary>
        /// Consecutive failures needed to report unhealthy
        /// </summary>
        [ArgKey("--health-retries")]
        public DockerRunTask HealthRetries(int healthRetries)
        {
            WithArgumentsKeyFromAttribute(healthRetries.ToString());
            return this;
        }

        /// <summary>
        /// Start period for the container to initialize before starting health-retries countdown (ms|s|m|h) (default 0s)

        /// </summary>
        [ArgKey("--health-start-period")]
        public DockerRunTask HealthStartPeriod(string healthStartPeriod)
        {
            WithArgumentsKeyFromAttribute(healthStartPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Maximum time to allow one check to run (ms|s|m|h) (default 0s)

        /// </summary>
        [ArgKey("--health-timeout")]
        public DockerRunTask HealthTimeout(string healthTimeout)
        {
            WithArgumentsKeyFromAttribute(healthTimeout.ToString());
            return this;
        }

        /// <summary>
        /// Print usage
        /// </summary>
        [ArgKey("--help")]
        public DockerRunTask Help()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Container host name
        /// </summary>
        [ArgKey("--hostname")]
        public DockerRunTask Hostname(string hostname)
        {
            WithArgumentsKeyFromAttribute(hostname.ToString());
            return this;
        }

        /// <summary>
        /// Run an init inside the container that forwards signals and reaps processes

        /// </summary>
        [ArgKey("--init")]
        public DockerRunTask Init()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Keep STDIN open even if not attached
        /// </summary>
        [ArgKey("--interactive")]
        public DockerRunTask Interactive()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Maximum IO bandwidth limit for the system drive (Windows only)

        /// </summary>
        [ArgKey("--io-maxbandwidth")]
        public DockerRunTask IoMaxbandwidth(string ioMaxbandwidth)
        {
            WithArgumentsKeyFromAttribute(ioMaxbandwidth.ToString());
            return this;
        }

        /// <summary>
        /// Maximum IOps limit for the system drive (Windows only)
        /// </summary>
        [ArgKey("--io-maxiops")]
        public DockerRunTask IoMaxiops(ulong ioMaxiops)
        {
            WithArgumentsKeyFromAttribute(ioMaxiops.ToString());
            return this;
        }

        /// <summary>
        /// IPv4 address (e.g., 172.30.100.104)
        /// </summary>
        [ArgKey("--ip")]
        public DockerRunTask Ip(string ip)
        {
            WithArgumentsKeyFromAttribute(ip.ToString());
            return this;
        }

        /// <summary>
        /// IPv6 address (e.g., 2001:db8::33)
        /// </summary>
        [ArgKey("--ip6")]
        public DockerRunTask Ip6(string ip6)
        {
            WithArgumentsKeyFromAttribute(ip6.ToString());
            return this;
        }

        /// <summary>
        /// IPC mode to use
        /// </summary>
        [ArgKey("--ipc")]
        public DockerRunTask Ipc(string ipc)
        {
            WithArgumentsKeyFromAttribute(ipc.ToString());
            return this;
        }

        /// <summary>
        /// Container isolation technology
        /// </summary>
        [ArgKey("--isolation")]
        public DockerRunTask Isolation(string isolation)
        {
            WithArgumentsKeyFromAttribute(isolation.ToString());
            return this;
        }

        /// <summary>
        /// Kernel memory limit
        /// </summary>
        [ArgKey("--kernel-memory")]
        public DockerRunTask KernelMemory(string kernelMemory)
        {
            WithArgumentsKeyFromAttribute(kernelMemory.ToString());
            return this;
        }

        /// <summary>
        /// Set meta data on a container
        /// </summary>
        [ArgKey("--label")]
        public DockerRunTask Label(string label)
        {
            WithArgumentsKeyFromAttribute(label.ToString());
            return this;
        }

        /// <summary>
        /// Read in a line delimited file of labels
        /// </summary>
        [ArgKey("--label-file")]
        public DockerRunTask LabelFile(string labelFile)
        {
            WithArgumentsKeyFromAttribute(labelFile.ToString());
            return this;
        }

        /// <summary>
        /// Add link to another container
        /// </summary>
        [ArgKey("--link")]
        public DockerRunTask Link(string link)
        {
            WithArgumentsKeyFromAttribute(link.ToString());
            return this;
        }

        /// <summary>
        /// Container IPv4/IPv6 link-local addresses
        /// </summary>
        [ArgKey("--link-local-ip")]
        public DockerRunTask LinkLocalIp(string linkLocalIp)
        {
            WithArgumentsKeyFromAttribute(linkLocalIp.ToString());
            return this;
        }

        /// <summary>
        /// Logging driver for the container
        /// </summary>
        [ArgKey("--log-driver")]
        public DockerRunTask LogDriver(string logDriver)
        {
            WithArgumentsKeyFromAttribute(logDriver.ToString());
            return this;
        }

        /// <summary>
        /// Log driver options
        /// </summary>
        [ArgKey("--log-opt")]
        public DockerRunTask LogOpt(string logOpt)
        {
            WithArgumentsKeyFromAttribute(logOpt.ToString());
            return this;
        }

        /// <summary>
        /// Container MAC address (e.g., 92:d0:c6:0a:29:33)
        /// </summary>
        [ArgKey("--mac-address")]
        public DockerRunTask MacAddress(string macAddress)
        {
            WithArgumentsKeyFromAttribute(macAddress.ToString());
            return this;
        }

        /// <summary>
        /// Memory limit
        /// </summary>
        [ArgKey("--memory")]
        public DockerRunTask Memory(string memory)
        {
            WithArgumentsKeyFromAttribute(memory.ToString());
            return this;
        }

        /// <summary>
        /// Memory soft limit
        /// </summary>
        [ArgKey("--memory-reservation")]
        public DockerRunTask MemoryReservation(string memoryReservation)
        {
            WithArgumentsKeyFromAttribute(memoryReservation.ToString());
            return this;
        }

        /// <summary>
        /// Swap limit equal to memory plus swap: '-1' to enable unlimited swap

        /// </summary>
        [ArgKey("--memory-swap")]
        public DockerRunTask MemorySwap(string memorySwap)
        {
            WithArgumentsKeyFromAttribute(memorySwap.ToString());
            return this;
        }

        /// <summary>
        /// Tune container memory swappiness (0 to 100)
        /// </summary>
        [ArgKey("--memory-swappiness")]
        public DockerRunTask MemorySwappiness(long memorySwappiness)
        {
            WithArgumentsKeyFromAttribute(memorySwappiness.ToString());
            return this;
        }

        /// <summary>
        /// Attach a filesystem mount to the container
        /// </summary>
        [ArgKey("--mount")]
        public DockerRunTask Mount(string mount)
        {
            WithArgumentsKeyFromAttribute(mount.ToString());
            return this;
        }

        /// <summary>
        /// Assign a name to the container
        /// </summary>
        [ArgKey("--name")]
        public DockerRunTask Name(string name)
        {
            WithArgumentsKeyFromAttribute(name.ToString());
            return this;
        }

        /// <summary>
        /// Connect a container to a network
        /// </summary>
        [ArgKey("--net")]
        public DockerRunTask Net(string net)
        {
            WithArgumentsKeyFromAttribute(net.ToString());
            return this;
        }

        /// <summary>
        /// Add network-scoped alias for the container
        /// </summary>
        [ArgKey("--net-alias")]
        public DockerRunTask NetAlias(string netAlias)
        {
            WithArgumentsKeyFromAttribute(netAlias.ToString());
            return this;
        }

        /// <summary>
        /// Connect a container to a network
        /// </summary>
        [ArgKey("--network")]
        public DockerRunTask Network(string network)
        {
            WithArgumentsKeyFromAttribute(network.ToString());
            return this;
        }

        /// <summary>
        /// Add network-scoped alias for the container
        /// </summary>
        [ArgKey("--network-alias")]
        public DockerRunTask NetworkAlias(string networkAlias)
        {
            WithArgumentsKeyFromAttribute(networkAlias.ToString());
            return this;
        }

        /// <summary>
        /// Disable any container-specified HEALTHCHECK
        /// </summary>
        [ArgKey("--no-healthcheck")]
        public DockerRunTask NoHealthcheck()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Disable OOM Killer
        /// </summary>
        [ArgKey("--oom-kill-disable")]
        public DockerRunTask OomKillDisable()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Tune host's OOM preferences (-1000 to 1000)
        /// </summary>
        [ArgKey("--oom-score-adj")]
        public DockerRunTask OomScoreAdj(int oomScoreAdj)
        {
            WithArgumentsKeyFromAttribute(oomScoreAdj.ToString());
            return this;
        }

        /// <summary>
        /// PID namespace to use
        /// </summary>
        [ArgKey("--pid")]
        public DockerRunTask Pid(string pid)
        {
            WithArgumentsKeyFromAttribute(pid.ToString());
            return this;
        }

        /// <summary>
        /// Tune container pids limit (set -1 for unlimited)
        /// </summary>
        [ArgKey("--pids-limit")]
        public DockerRunTask PidsLimit(long pidsLimit)
        {
            WithArgumentsKeyFromAttribute(pidsLimit.ToString());
            return this;
        }

        /// <summary>
        /// Set platform if server is multi-platform capable
        /// </summary>
        [ArgKey("--platform")]
        public DockerRunTask Platform(string platform)
        {
            WithArgumentsKeyFromAttribute(platform.ToString());
            return this;
        }

        /// <summary>
        /// Give extended privileges to this container
        /// </summary>
        [ArgKey("--privileged")]
        public DockerRunTask Privileged()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Publish a container's port(s) to the host
        /// </summary>
        [ArgKey("--publish")]
        public DockerRunTask Publish(string publish)
        {
            WithArgumentsKeyFromAttribute(publish.ToString());
            return this;
        }

        /// <summary>
        /// Publish all exposed ports to random ports
        /// </summary>
        [ArgKey("--publish-all")]
        public DockerRunTask PublishAll()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Mount the container's root filesystem as read only
        /// </summary>
        [ArgKey("--read-only")]
        public DockerRunTask ReadOnly()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Restart policy to apply when a container exits
        /// </summary>
        [ArgKey("--restart")]
        public DockerRunTask Restart(string restart)
        {
            WithArgumentsKeyFromAttribute(restart.ToString());
            return this;
        }

        /// <summary>
        /// Automatically remove the container when it exits
        /// </summary>
        [ArgKey("--rm")]
        public DockerRunTask Rm()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Runtime to use for this container
        /// </summary>
        [ArgKey("--runtime")]
        public DockerRunTask Runtime(string runtime)
        {
            WithArgumentsKeyFromAttribute(runtime.ToString());
            return this;
        }

        /// <summary>
        /// Security Options
        /// </summary>
        [ArgKey("--security-opt")]
        public DockerRunTask SecurityOpt(string securityOpt)
        {
            WithArgumentsKeyFromAttribute(securityOpt.ToString());
            return this;
        }

        /// <summary>
        /// Size of /dev/shm
        /// </summary>
        [ArgKey("--shm-size")]
        public DockerRunTask ShmSize(string shmSize)
        {
            WithArgumentsKeyFromAttribute(shmSize.ToString());
            return this;
        }

        /// <summary>
        /// Proxy received signals to the process
        /// </summary>
        [ArgKey("--sig-proxy")]
        public DockerRunTask SigProxy()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Signal to stop a container
        /// </summary>
        [ArgKey("--stop-signal")]
        public DockerRunTask StopSignal(string stopSignal)
        {
            WithArgumentsKeyFromAttribute(stopSignal.ToString());
            return this;
        }

        /// <summary>
        /// Timeout (in seconds) to stop a container
        /// </summary>
        [ArgKey("--stop-timeout")]
        public DockerRunTask StopTimeout(int stopTimeout)
        {
            WithArgumentsKeyFromAttribute(stopTimeout.ToString());
            return this;
        }

        /// <summary>
        /// Storage driver options for the container
        /// </summary>
        [ArgKey("--storage-opt")]
        public DockerRunTask StorageOpt(string storageOpt)
        {
            WithArgumentsKeyFromAttribute(storageOpt.ToString());
            return this;
        }

        /// <summary>
        /// Sysctl options
        /// </summary>
        [ArgKey("--sysctl")]
        public DockerRunTask Sysctl(string sysctl)
        {
            WithArgumentsKeyFromAttribute(sysctl.ToString());
            return this;
        }

        /// <summary>
        /// Mount a tmpfs directory
        /// </summary>
        [ArgKey("--tmpfs")]
        public DockerRunTask Tmpfs(string tmpfs)
        {
            WithArgumentsKeyFromAttribute(tmpfs.ToString());
            return this;
        }

        /// <summary>
        /// Allocate a pseudo-TTY
        /// </summary>
        [ArgKey("--tty")]
        public DockerRunTask Tty()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Ulimit options
        /// </summary>
        [ArgKey("--ulimit")]
        public DockerRunTask Ulimit(string ulimit)
        {
            WithArgumentsKeyFromAttribute(ulimit.ToString());
            return this;
        }

        /// <summary>
        /// Username or UID (format: <name|uid>[:<group|gid>])
        /// </summary>
        [ArgKey("--user")]
        public DockerRunTask User(string user)
        {
            WithArgumentsKeyFromAttribute(user.ToString());
            return this;
        }

        /// <summary>
        /// User namespace to use
        /// </summary>
        [ArgKey("--userns")]
        public DockerRunTask Userns(string userns)
        {
            WithArgumentsKeyFromAttribute(userns.ToString());
            return this;
        }

        /// <summary>
        /// UTS namespace to use
        /// </summary>
        [ArgKey("--uts")]
        public DockerRunTask Uts(string uts)
        {
            WithArgumentsKeyFromAttribute(uts.ToString());
            return this;
        }

        /// <summary>
        /// Bind mount a volume
        /// </summary>
        [ArgKey("--volume")]
        public DockerRunTask Volume(string volume)
        {
            WithArgumentsKeyFromAttribute(volume.ToString());
            return this;
        }

        /// <summary>
        /// Optional volume driver for the container
        /// </summary>
        [ArgKey("--volume-driver")]
        public DockerRunTask VolumeDriver(string volumeDriver)
        {
            WithArgumentsKeyFromAttribute(volumeDriver.ToString());
            return this;
        }

        /// <summary>
        /// Mount volumes from the specified container(s)
        /// </summary>
        [ArgKey("--volumes-from")]
        public DockerRunTask VolumesFrom(string volumesFrom)
        {
            WithArgumentsKeyFromAttribute(volumesFrom.ToString());
            return this;
        }

        /// <summary>
        /// Working directory inside the container
        /// </summary>
        [ArgKey("--workdir")]
        public DockerRunTask Workdir(string workdir)
        {
            WithArgumentsKeyFromAttribute(workdir.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);
 WithArguments(_command);
 WithArguments(_arg);

            return base.DoExecute(context);
        }

     }
}
