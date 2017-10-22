using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    public class Entity
    {
        [JsonProperty(PropertyName = "minecraft:entity")]
        public MinecraftEntity minecraftEntity { get; set; }
    }

    public class MinecraftEntity
    {
        public bool ShouldSerializeComponentGroups()
        {
            return ComponentGroups?.Count > 0;
        }

        [JsonProperty(PropertyName = "format_version")]
        public string format_version { get; set; }

        [JsonProperty(PropertyName = "component_groups", NullValueHandling = NullValueHandling.Ignore)]
        //public Dictionary<string, Dictionary<string, MCDataStructures.Component>> ComponentGroups { get; set; }
        public Dictionary<string, object> ComponentGroups { get; set; }

        [JsonProperty(PropertyName = "components")]
        [JsonConverter(typeof(Serializers.EntityComponentsConverter))]
        public Dictionary<string, Component> Components { get; set; }

        [JsonProperty(PropertyName = "events", NullValueHandling = NullValueHandling.Ignore)]
        //public Dictionary<string, MCDataStructures.Component> components { get; set; }
        public Dictionary<string, object> Events { get; set; }
    }

}
