using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{

    public class EntityTypes
    {
        [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Filter>))]
        public List<Filter> filters { get; set; }// Minecraft Filter Conditions that make this entry in the list valid

        [JsonProperty(PropertyName = "max_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float max_dist { get; set; } // 16	Maximum distance this mob can be away to be a valid choice

        [JsonProperty(PropertyName = "must_see", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool must_see { get; set; } // Boolean false	If true, the mob has to be visible to be a valid choice

        [JsonProperty(PropertyName = "sprint_speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float sprint_speed_multiplier { get; set; } // 1.0	Multiplier for the running speed.A value of 1.0 means the speed is unchanged

        [JsonProperty(PropertyName = "walk_speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float walk_speed_multiplier { get; set; } // 1.0	Multiplier for the walking speed.A value of 1.0 means the speed is unchanged
    }
}
