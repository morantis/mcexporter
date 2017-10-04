using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Exporter
{
    public class LootTable
    {
        [JsonIgnore]
        public string Name { get; internal set; }

        public class Pool
        {
            public abstract class Rolls
            {
                public static implicit operator Rolls(Int64 value)
                {
                    return new ConstantRolls(value);
                }
            }

            public class MinMaxRolls : Rolls
            {
                [JsonProperty(PropertyName = "min", NullValueHandling = NullValueHandling.Ignore)]
                public Int64 Min { get; set; }

                [JsonProperty(PropertyName = "max", NullValueHandling = NullValueHandling.Ignore)]
                public Int64 Max { get; set; }
            }

            public class ConstantRolls : Rolls
            {
                public ConstantRolls(Int64 val)
                {
                    Value = val;
                }

                [JsonProperty(PropertyName = "rolls", NullValueHandling = NullValueHandling.Ignore)]
                public Int64 Value { get; set; }
            }

            [JsonProperty(PropertyName = "rolls", NullValueHandling = NullValueHandling.Ignore)]
            public Rolls Roll { get; set; }
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
                [JsonProperty(PropertyName = "func", NullValueHandling = NullValueHandling.Ignore)]
                public string Func { get; set; }

                public class Count
                {
                    [JsonProperty(PropertyName = "min", NullValueHandling = NullValueHandling.Ignore)]
                    public int Min { get; set; }

                    [JsonProperty(PropertyName = "max", NullValueHandling = NullValueHandling.Ignore)]
                    public int Max { get; set; }
                }

                [JsonProperty(PropertyName = "count", NullValueHandling = NullValueHandling.Ignore)]
                public Count CountItem { get; set; }
            }

            [JsonProperty(PropertyName = "functions", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<Pool>))]
            public List<Function> Functions { get; set; }

            [JsonProperty(PropertyName = "weight", NullValueHandling = NullValueHandling.Ignore)]
            public int Weight { get; set; }
        }
    }
}