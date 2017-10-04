using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Exporter
{
    public class Trading
    {
        internal void Save(string packDirectory)
        {
            string subDirectory = packDirectory + "\\trading\\entities";
            Directory.CreateDirectory(subDirectory);

            foreach (var trade in Trades)
            {
                var json = JsonConvert.SerializeObject(trade, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\" + trade.Name + ".json", json);
            }
        }

        public List<Trade> Trades { get; set; } = new List<Trade>();
    }
}