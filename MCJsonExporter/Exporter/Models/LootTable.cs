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

        [JsonProperty(PropertyName = "pools", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Pool>))]
        public List<Pool> Pools { get; set; }
    }
}