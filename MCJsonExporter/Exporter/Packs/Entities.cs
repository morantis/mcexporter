using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Exporter
{
    public class Entities
    {
        public Dictionary<string, Entity> Instances { get; internal set; } = new Dictionary<string, Entity>();

        internal void Save(string packDirectory)
        {
            string subDirectory = packDirectory + "\\entities";
            Directory.CreateDirectory(subDirectory);

            foreach (var pair in Instances)
            {
                var json = JsonConvert.SerializeObject(pair.Value, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\" + pair.Key + ".json", json);
            }

        }
    }
}