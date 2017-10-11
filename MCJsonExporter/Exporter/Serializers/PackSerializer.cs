using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter.Serializers
{
    public class PackSerializer
    {
        public static bool Serialize(BehaviorPack pack, string ProjectName, string outputDirectory)
        {
            var now = DateTime.Now;
            string packDirectory = outputDirectory + "/" + ProjectName + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + "_" + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();

            try
            {
                Directory.CreateDirectory(packDirectory);

                pack.Manifest.Save(packDirectory);
                pack.Entities.Save(packDirectory);
                pack.LootTables.Save(packDirectory);
                pack.Trading.Save(packDirectory);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unable to create behavior pack at " + packDirectory);
                Console.Write(exception.Message);
                return false;
            }

            return true;
        }

        static public BehaviorPack Deserialize(string root)
        {
            BehaviorPack pack = new BehaviorPack();
            try
            {
                // Parse the manifest
                pack.Manifest = JsonConvert.DeserializeObject<Manifest>(File.ReadAllText(root + "/manifest.json"), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

                // Verify the icon exists. We will simply copy it later
                if (!File.Exists(root + "/pack_icon.png"))
                {
                    throw new FileNotFoundException("Couldn't find " + root + "/pack_icon.png. Don't be a chump.");
                }

                // Entities, loot tables and trading are all optional sub directories

                if (Directory.Exists(root + "/entities"))
                {
                    pack.Entities = ExtractEntities(root);
                }

                if (Directory.Exists(root + "/loot_tables"))
                {
                    pack.LootTables = ExtractLootTables(root);
                }

                if (Directory.Exists(root + "/Trading"))
                {
                    pack.Trading = ExtractTrading(root);
                }
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine("Unable to Extract pack at " + root);
                Console.Write(fileNotFound.Message);
                return null;
            }

            return pack;
        }

        static public Entities ExtractEntities(string root)
        {
            var entities = new Entities();
            foreach (var file in Directory.EnumerateFiles(root + "/entities", "*.json"))
            {
                var entity = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(file));
                entities.Instances.Add(Path.GetFileNameWithoutExtension(file), entity);
            }

            return entities;
        }

        static public LootTables ExtractLootTables(string root)
        {
            var lootTables = new LootTables();

            // Chests
            foreach (var file in Directory.EnumerateFiles(root + "/loot_tables/chests", "*.json"))
            {
                dynamic chest = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                chest.Name = Path.GetFileNameWithoutExtension(file);
                lootTables.Chests.Add(chest);
            }

            // Entities
            foreach (var file in Directory.EnumerateFiles(root + "/loot_tables/entities", "*.json"))
            {
                var entity = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                entity.Name = Path.GetFileNameWithoutExtension(file);
                lootTables.Entities.Add(entity);
            }

            // Equipment
            foreach (var file in Directory.EnumerateFiles(root + "/loot_tables/equipment", "*.json"))
            {
                var equipment = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(file), new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
                equipment.Name = Path.GetFileNameWithoutExtension(file);
                lootTables.Equipment.Add(equipment);
            }

            // Fishing
            lootTables.Gameplay.FishingJson = JsonConvert.DeserializeObject<LootTable>(File.ReadAllText(root + "/loot_tables/gameplay/fishing.json"), new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
            foreach (var file in Directory.EnumerateFiles(root + "/loot_tables/gameplay/Fishing", "*.json"))
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

        static public Trading ExtractTrading(string root)
        {
            var trading = new Trading();
            foreach (var file in Directory.EnumerateFiles(root + "/trading", "*.json"))
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
    }

}
