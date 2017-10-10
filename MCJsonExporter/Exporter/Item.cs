using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter
{
    public class Item
    {
        [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        [JsonProperty(PropertyName = "quantity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MinMaxOrIntConverter))]
        public MinMaxOrInt Quanity { get; set; }

        public class Function
        {
            [JsonProperty(PropertyName = "function", NullValueHandling = NullValueHandling.Ignore)]
            public string FunctionName { get; set; }

            [JsonProperty(PropertyName = "treasure", NullValueHandling = NullValueHandling.Ignore)]
            public bool Treasure { get; set; }

            [JsonProperty(PropertyName = "levels", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(MinMaxOrIntConverter))]
            public MinMaxOrInt Levels { get; set; }

            [JsonProperty(PropertyName = "base_cost", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int BaseCost { get; set; }

            [JsonProperty(PropertyName = "base_random_cost", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int BaseRandomCost { get; set; }

            [JsonProperty(PropertyName = "per_level_random_cost", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int PerLevelRandomCost { get; set; }

            [JsonProperty(PropertyName = "per_level_cost", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int PerLevelCost { get; set; }

            [JsonProperty(PropertyName = "destination", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Destination { get; set; }
        }

        [JsonProperty(PropertyName = "functions", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Function>))]
        public List<Function> Functions { get; set; }
    }

}
