using Newtonsoft.Json;
using System.Collections.Generic;

namespace Exporter
{
    public class Trade
    {
        public string Name { get; set; }

        public class Tier
        {
            public class Trade
            {
                public class Item
                {
                    [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore)]
                    public string ItemName { get; set; }

                    [JsonProperty(PropertyName = "quantity", NullValueHandling = NullValueHandling.Ignore)]
                    public MinMaxOrInt Quanity { get; set; }

                    public class Function
                    {
                        [JsonProperty(PropertyName = "function", NullValueHandling = NullValueHandling.Ignore)]
                        public string FunctionName { get; set; }

                        [JsonProperty(PropertyName = "treasure", NullValueHandling = NullValueHandling.Ignore)]
                        public bool Treasure { get; set; }

                        [JsonProperty(PropertyName = "levels", NullValueHandling = NullValueHandling.Ignore)]
                        public MinMaxOrInt Levels { get; set; }

                        [JsonProperty(PropertyName = "base_cost", NullValueHandling = NullValueHandling.Ignore)]
                        public int BaseCost { get; set; }

                        [JsonProperty(PropertyName = "base_random_cost", NullValueHandling = NullValueHandling.Ignore)]
                        public int BaseRandomCost { get; set; }

                        [JsonProperty(PropertyName = "per_level_random_cost", NullValueHandling = NullValueHandling.Ignore)]
                        public int PerLevelRandomCost { get; set; }

                        [JsonProperty(PropertyName = "per_level_cost", NullValueHandling = NullValueHandling.Ignore)]
                        public int PerLevelCost { get; set; }

                        [JsonProperty(PropertyName = "destination", NullValueHandling = NullValueHandling.Ignore)]
                        public string Destination { get; set; }
                    }

                    [JsonProperty(PropertyName = "functions", NullValueHandling = NullValueHandling.Ignore)]
                    [JsonConverter(typeof(SingleOrArrayConverter<Function>))]
                    public Function Functions { get; set; }
                }

                [JsonProperty(PropertyName = "wants", NullValueHandling = NullValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<Item>))]
                public Item Wants { get; set; }

                [JsonProperty(PropertyName = "gives", NullValueHandling = NullValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<Item>))]
                public Item Gives { get; set; }
            }

            [JsonProperty(PropertyName = "trades", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<Trade>))]
            public List<Trade> Trades { get; set; }
        }

        [JsonProperty(PropertyName = "tiers", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Tier>))]
        public List<Tier> Tiers { get; set; }
    }
}