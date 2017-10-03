using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Exporter
{
    public class LootTables
    {
        public List<LootTable> Chests { get; internal set; } = new List<LootTable>();
        public List<LootTable> Entities { get; internal set; } = new List<LootTable>();
        public List<LootTable> Equipment { get; internal set; } = new List<LootTable>();
        public Gameplay Gameplay { get; internal set; } = new Gameplay();

        internal void Save(string packDirectory)
        {
            string subDirectory = packDirectory + "\\chests";
            Directory.CreateDirectory(subDirectory);
            foreach (var chest in Chests)
            {
                var json = JsonConvert.SerializeObject(chest, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\" + chest.Name + ".json", json);
            }

            subDirectory = packDirectory + "\\entities";
            Directory.CreateDirectory(subDirectory);
            foreach (var entity in Entities)
            {
                var json = JsonConvert.SerializeObject(entity, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\" + entity.Name + ".json", json);
            }

            subDirectory = packDirectory + "\\equipment";
            Directory.CreateDirectory(subDirectory);
            foreach (var equipment in Equipment)
            {
                var json = JsonConvert.SerializeObject(equipment, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\" + equipment.Name + ".json", json);
            }

            subDirectory = packDirectory + "\\gameplay";
            Directory.CreateDirectory(subDirectory);
            {
                var json = JsonConvert.SerializeObject(Gameplay.FishingJson, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\fishing.json", json);
            }

            subDirectory = packDirectory + "\\gameplay\\fishing";
            foreach (var fishing in Gameplay.Fishing)
            {
                var json = JsonConvert.SerializeObject(fishing, Formatting.Indented);
                File.WriteAllText(subDirectory + "\\" + fishing.Name + ".json", json);
            }
        }
    }
}