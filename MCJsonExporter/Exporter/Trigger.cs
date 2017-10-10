using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    public class Trigger
    {
        [JsonProperty(PropertyName = "event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Event { get; set; }

        [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<Filter>))]
        public List<Filter> filters { get; set; }

        [JsonProperty(PropertyName = "target", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Target { get; set; }
    }
}
