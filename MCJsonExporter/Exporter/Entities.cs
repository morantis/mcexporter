using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Exporter
{
    public class Entities
    {
        public List<Entity> Instances { get; internal set; } = new List<Entity>();

        internal void Save(string packDirectory)
        {
            string subDirectory = packDirectory + "\\entities";
            Directory.CreateDirectory(subDirectory);

            foreach (var instance in Instances)
            {
                var json = JsonConvert.SerializeObject(instance, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\" + instance.Name + ".json", json);
            }

        }
    }
}