using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running
    /// </summary>
    public partial class PodAffinityTermV1
    {
        /// <summary>
        ///     This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
        /// </summary>
        [JsonProperty("topologyKey")]
        [YamlMember(Alias = "topologyKey")]
        public string TopologyKey { get; set; }

        /// <summary>
        ///     namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
        /// </summary>
        [YamlMember(Alias = "namespaces")]
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Namespaces { get; set; } = new List<string>();

        /// <summary>
        ///     A label query over a set of resources, in this case pods.
        /// </summary>
        [JsonProperty("labelSelector")]
        [YamlMember(Alias = "labelSelector")]
        public LabelSelectorV1 LabelSelector { get; set; }
    }
}
