using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exporter
{
    public class Function
    {
        [JsonProperty(PropertyName = "function", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Func { get; set; }

        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "levels", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(MinMaxOrIntConverter))]
        public MinMaxOrInt Levels { get; set; }

        [JsonProperty(PropertyName = "treasure", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Treasure { get; set; }

        [JsonProperty(PropertyName = "chance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Chance { get; set; }

        [JsonProperty(PropertyName = "count", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(MinMaxOrIntConverter))]
        public MinMaxOrInt CountItem { get; set; }

        [JsonProperty(PropertyName = "damage", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(MinMaxOrIntConverter))]
        public MinMaxOrInt Damage { get; set; }

        [JsonProperty(PropertyName = "data", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Data { get; set; }

        [JsonProperty(PropertyName = "conditions", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Condition>))]
        public List<Condition> ConditionColl { get; set; }
    }

}
