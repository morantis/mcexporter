using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exporter
{

    public class Pool
    {
        [JsonProperty(PropertyName = "conditions", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Condition>))]
        public List<Condition> ConditionColl { get; set; }

        [JsonProperty(PropertyName = "rolls", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(MinMaxOrIntConverter))]
        public MinMaxOrInt Roll { get; set; }

        [JsonProperty(PropertyName = "entries", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Entry>))]
        public List<Entry> Entries { get; set; }
    }
}
