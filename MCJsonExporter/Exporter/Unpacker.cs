using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Exporter
{
    public class Unpacker
    {
        public string Root { get; set; }

        public static Unpacker Create(string rootDirectory)
        {
            // find the directory
            if (Directory.Exists(rootDirectory))
            {
                return new Unpacker() { Root = rootDirectory };
            }

            return null;
        }

        public Entities ExtractEntities()
        {
            var entities = new Entities();
            foreach (var file in Directory.EnumerateFiles(Root + "/entities", "*.json"))
            {
                var entity = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(file));
                entity.Name = Path.GetFileNameWithoutExtension(file);
                entities.Instances.Add(entity);
            }

            return entities;
        }

        public LootTables ExtractLootTables()
        {
            var lootTables = new LootTables();

            // Chests
            foreach (var file in Directory.EnumerateFiles(Root + "/loot_tables/chests", "*.json"))
            {
                dynamic chest = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                chest.Name = Path.GetFileNameWithoutExtension(file);
                lootTables.Chests.Add(chest);
            }

            // Entities
            foreach (var file in Directory.EnumerateFiles(Root + "/loot_tables/entities", "*.json"))
            {
                var entity = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                entity.Name = Path.GetFileNameWithoutExtension(file);
                lootTables.Entities.Add(entity);
            }

            // Equipment
            foreach (var file in Directory.EnumerateFiles(Root + "/loot_tables/equipment", "*.json"))
            {
                var equipment = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                equipment.Name = Path.GetFileNameWithoutExtension(file);
                lootTables.Equipment.Add(equipment);
            }

            // Fishing
            lootTables.Gameplay.FishingJson = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(Root + "/loot_tables/gameplay/fishing.json"), new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
            foreach (var file in Directory.EnumerateFiles(Root + "/loot_tables/gameplay/Fishing", "*.json"))
            {
                var fishing = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                fishing.Name = Path.GetFileNameWithoutExtension(file);
                lootTables.Gameplay.Fishing.Add(fishing);
            }


            return lootTables;
        }

        public Trading ExtractTrading()
        {
            var trading = new Trading();
            foreach (var file in Directory.EnumerateFiles(Root + "/trading", "*.json"))
            {
                var trade = JsonConvert.DeserializeObject<Trade>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                trade.Name = Path.GetFileNameWithoutExtension(file);
                trading.Trades.Add(trade);
            }
            return trading;
        }

        public BehaviorPack Extract()
        {
            BehaviorPack pack = new BehaviorPack();
            try
            {
                // Parse the manifest
                pack.Manifest = JsonConvert.DeserializeObject<Manifest>(File.ReadAllText(Root + "/manifest.json"), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

                // Verify the icon exists. We will simply copy it later
                if (!File.Exists(Root + "/pack_icon.png"))
                {
                    throw new FileNotFoundException("Couldn't find " + Root + "/pack_icon.png. Don't be a chump.");
                }

                // Entities, loot tables and trading are all optional sub directories

                if (Directory.Exists(Root + "/entities"))
                {
                    pack.Entities = ExtractEntities();
                }

                if (Directory.Exists(Root + "/loot_tables"))
                {
                    pack.LootTables = ExtractLootTables();
                }

                if (Directory.Exists(Root + "/Trading"))
                {
                    pack.Trading = ExtractTrading();
                }
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine("Unable to Extract pack at " + Root);
                Console.Write(fileNotFound.Message);
                return null;
            }

            return pack;
        }
    }
}
