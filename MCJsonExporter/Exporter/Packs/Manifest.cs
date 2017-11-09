using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Exporter
{
    public class Manifest
    {
        public string format_version { get; set; }

        public class UnnamedData
        {
            [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "uuid", NullValueHandling = NullValueHandling.Ignore)]
            public string UUID { get; set; }

            [JsonProperty(PropertyName = "version", NullValueHandling = NullValueHandling.Ignore)]
            public int[] Version { get; set; }
        }

        [JsonProperty(PropertyName = "header", NullValueHandling = NullValueHandling.Ignore)]
        public UnnamedData Header { get; set; }

        [JsonProperty(PropertyName = "modules", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<UnnamedData>))]
        public List<UnnamedData> Modules { get; set; }

        //[JsonProperty(PropertyName = "dependencies", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(SingleOrArrayConverter<UnnamedData>))]
        //public List<UnnamedData> Dependencies { get; set; }

        internal void Save(string packDirectory)
        {
            Header.Description = "Moba";
            Modules[0].Description = "Moba";
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);

            File.WriteAllText(packDirectory + "\\manifest.json", json);
        }
    }
}
