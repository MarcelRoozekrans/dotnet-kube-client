using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ContainerStatus contains details for the current status of this container.
    /// </summary>
    public partial class ContainerStatusV1
    {
        /// <summary>
        ///     The image the container is running. More info: https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        [JsonProperty("image")]
        [YamlMember(Alias = "image")]
        public string Image { get; set; }

        /// <summary>
        ///     ImageID of the container's image.
        /// </summary>
        [JsonProperty("imageID")]
        [YamlMember(Alias = "imageID")]
        public string ImageID { get; set; }

        /// <summary>
        ///     Container's ID in the format 'docker://&lt;container_id&gt;'.
        /// </summary>
        [JsonProperty("containerID")]
        [YamlMember(Alias = "containerID")]
        public string ContainerID { get; set; }

        /// <summary>
        ///     Specifies whether the container has passed its readiness probe.
        /// </summary>
        [JsonProperty("ready")]
        [YamlMember(Alias = "ready")]
        public bool Ready { get; set; }

        /// <summary>
        ///     This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated.
        /// </summary>
        [JsonProperty("name")]
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Details about the container's last termination condition.
        /// </summary>
        [JsonProperty("lastState")]
        [YamlMember(Alias = "lastState")]
        public ContainerStateV1 LastState { get; set; }

        /// <summary>
        ///     Details about the container's current condition.
        /// </summary>
        [JsonProperty("state")]
        [YamlMember(Alias = "state")]
        public ContainerStateV1 State { get; set; }

        /// <summary>
        ///     The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC.
        /// </summary>
        [JsonProperty("restartCount")]
        [YamlMember(Alias = "restartCount")]
        public int RestartCount { get; set; }
    }
}
