using Newtonsoft.Json;
using System.Collections.Generic;

namespace Exporter
{
    public class Trade
    {
        [JsonIgnore]
        public string Name { get; set; }

        public class Tier
        {
            public class Trade
            {
                [JsonProperty(PropertyName = "reward_exp", NullValueHandling = NullValueHandling.Ignore)]
                public bool RewardXP = true;

                [JsonProperty(PropertyName = "wants", NullValueHandling = NullValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<Item>))]
                public List<Item> Wants { get; set; }

                [JsonProperty(PropertyName = "gives", NullValueHandling = NullValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<Item>))]
                public List<Item> Gives { get; set; }
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