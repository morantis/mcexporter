using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    public class LootTable
    {
        [JsonIgnore]
        public string Name { get; internal set; }

        public class Pool
        {
            [JsonProperty(PropertyName = "rolls", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(RollsConverter))]
            public MinMaxOrInt Roll { get; set; }
        }

        [JsonProperty(PropertyName = "pools", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Pool>))]
        public List<Pool> Pools { get; set; }

        public class Entry
        {
            [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore)]
            public string Item { get; set; }

            [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            public class Function
            {
                [JsonProperty(PropertyName = "function", NullValueHandling = NullValueHandling.Ignore)]
                public string Func { get; set; }

                [JsonProperty(PropertyName = "treasure", NullValueHandling = NullValueHandling.Ignore)]
                public bool Treasure { get; set; }

                [JsonProperty(PropertyName = "count", NullValueHandling = NullValueHandling.Ignore)]
                public MinMaxOrInt CountItem { get; set; }

                [JsonProperty(PropertyName = "data", NullValueHandling = NullValueHandling.Ignore)]
                public int Data { get; set; }
            }

            [JsonProperty(PropertyName = "functions", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<Pool>))]
            public List<Function> Functions { get; set; }

            [JsonProperty(PropertyName = "weight", NullValueHandling = NullValueHandling.Ignore)]
            public int Weight { get; set; }

            [JsonProperty(PropertyName = "treasure", NullValueHandling = NullValueHandling.Ignore)]
            public bool Treasure { get; set; }
        }

        [JsonProperty(PropertyName = "entries", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Pool>))]
        public List<Entry> Entries { get; set; }
    }
}