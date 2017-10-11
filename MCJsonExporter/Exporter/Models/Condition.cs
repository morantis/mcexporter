using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exporter
{

    public class Condition
    {
        [JsonProperty(PropertyName = "condition", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "entity_type", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string EntityType { get; set; }

        [JsonProperty(PropertyName = "default_chance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float default_chance { get; set; }

        [JsonProperty(PropertyName = "chance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float chance { get; set; }

        [JsonProperty(PropertyName = "looting_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Looting_multiplier { get; set; }

        [JsonProperty(PropertyName = "peaceful", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float peaceful { get; set; }

        [JsonProperty(PropertyName = "hard", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float hard { get; set; }

    }

        //[JsonProperty(PropertyName = "entity", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public string Entity { get; set; }

        //[JsonProperty(PropertyName = "properties", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        //Dictionary<string, bool> Properties;
}
