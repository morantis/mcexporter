using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exporter.Controllers
{

    public class SourceSerializer
    {
        public class Entity
        {
            // Entity	Family	Health	Move	Equip	Loot	Melee	Range	EnemyFilterGroup
            public string Family { get; set; }
            public string Health { get; set; }
            public string Move { get; set; }
            public string Equip { get; set; }
            public string Loot { get; set; }
            public string Melee { get; set; }
            public string Range { get; set; }
            public string EnemyFilterGroup { get; set; }
        }


        public static Dictionary<string, Entity> ReadEntities(string sourceDirectory)
        {
            Dictionary<string, Entity> entities = new Dictionary<string, Entity>();

            if (!File.Exists(sourceDirectory + "/entities.csv"))
            {
                Console.WriteLine(sourceDirectory + "/entities.csv not found");
                return entities;
            }

            var enReader = File.OpenText(sourceDirectory + "/entities.csv");

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split([',']);

            }

            return entities;
        }

        public static bool ApplySource(BehaviorPack pack, string sourceDirectory)
        {
            if (!File.Exists(sourceDirectory))
            {
                Console.WriteLine(sourceDirectory + " not found.");
                return false;
            }

            // Read the csv fiels into memory
            ReadEntities(sourceDirectory);
        }
    }
}
