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
            public string Description { get; set; }
            public string Name { get; set; }
            public string UUIS { get; set; }
            public float[] Version { get; set; }
        }

        [JsonProperty(PropertyName = "header", NullValueHandling = NullValueHandling.Ignore)]
        public UnnamedData Header { get; set; }

        [JsonProperty(PropertyName = "modules", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<UnnamedData>))]
        public List<UnnamedData> Modules { get; set; }

        [JsonProperty(PropertyName = "dependencies", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(SingleOrArrayConverter<UnnamedData>))]
        public List<UnnamedData> Dependencies { get; set; }

        internal void Save(string packDirectory)
        {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);

            File.WriteAllText(packDirectory + "\\manifest.json", json);
        }
    }
}
