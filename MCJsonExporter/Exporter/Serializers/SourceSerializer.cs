using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exporter.Serializers
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

        public class AttackBehaviors
        {
            public int Priority { get; set; }
            public string EntityTypes { get; set; }
            public bool MustSee { get; set; }
            public bool MustReach { get; set; }
        }

        public class EntityTypes
        {
            public string Filter1 { get; set; }
            public int Distance1 { get; set; }

            public string Filter2 { get; set; }
            public int Distance2 { get; set; }

            public string Filter3 { get; set; }
            public int Distance3 { get; set; }
        }

        public class Families
        {
            public string Type1 { get; set; }
            public string Type2 { get; set; }
            public string Type3 { get; set; }
            public string Type4 { get; set; }
            public string Type5 { get; set; }
        }

        public class Filters
        {
            public string AnyAll { get; set; }
            public string Test1 { get; set; }
            public string Test2 { get; set; }
            public string Test3 { get; set; }
            public string Test4 { get; set; }
            public string Test5 { get; set; }
        }

        public class FilterTest
        {
            public string Test { get; set; }
            public string Subject { get; set; }
            public string Operator { get; set; }
            public string Value { get; set; }
        }

        public class Health
        {
            public int Default { get; set; }
            public int Max { get; set; }
        }

        public class Melee
        {
            public int Damage { get; set; }
        }

        public class Moves {
            public double Speed { get; set; }
            public bool Basic { get; set; }
            public bool Jump { get; set; }
            public bool Climb { get; set; }
        }

        public class Range
        {
            public string Projectile { get; set; }
            public int IntervalMin { get; set; }
            public int IntervalMax { get; set; }
            public int Radius { get; set; }
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
                var parts = line.Split(',');

                Entity entity = new Entity() { Family = parts[1], Health = parts[2], Move = parts[3], Equip = parts[4], Loot = parts[5], Melee = parts[6], Range = parts[7], EnemyFilterGroup = parts[8] };
                entities.Add(parts[0], entity);
            }

            return entities;
        }

        public static Dictionary<string, AttackBehaviors> ReadAttackBehavior(string sourceDirectory)
        {
            const string FileName = "/AttackBehaviors.csv";
            Dictionary<string, AttackBehaviors> coll = new Dictionary<string, AttackBehaviors>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new AttackBehaviors() { Priority = Convert.ToInt32(parts[1]), EntityTypes = parts[2], MustSee = Convert.ToBoolean(parts[3]), MustReach = Convert.ToBoolean(parts[4]));
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static Dictionary<string, Families> ReadFamilies(string sourceDirectory)
        {
            const string FileName = "/Families.csv";
            Dictionary<string, Families> coll = new Dictionary<string, Families>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new Families() { Type1 = parts[1], Type2 = parts[2], Type3 = parts[3], Type4 = parts[4], Type5 = parts[5], );
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static Dictionary<string, Filters> ReadFilters(string sourceDirectory)
        {
            const string FileName = "/Filters.csv";
            Dictionary<string, Filters> coll = new Dictionary<string, Filters>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new Filters()
                {
                    AnyAll = parts[1],
                    Test1 = parts[2],
                    Test2 = parts[3],
                    Test3 = parts[4],
                    Test4 = parts[5],
                    Test5 = parts[6]
                };
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static Dictionary<string, FilterTest> ReadFilterTest(string sourceDirectory)
        {
            const string FileName = "/FilterTests.csv";
            Dictionary<string, FilterTest> coll = new Dictionary<string, FilterTest>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new FilterTest() { Test = parts[1], Subject = parts[2], Operator = parts[3], Value = parts[4]};
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static Dictionary<string, Health> ReadHealth(string sourceDirectory)
        {
            const string FileName = "/Health.csv";
            Dictionary<string, Health> coll = new Dictionary<string, Health>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new Health() { Default = Convert.ToInt32(parts[1]), Max = Convert.ToInt32(parts[2]) };
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static Dictionary<string, Melee> ReadMelee(string sourceDirectory)
        {
            const string FileName = "/Melee.csv";
            Dictionary<string, Melee> coll = new Dictionary<string, Melee>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new Melee() { Damage = Convert.ToInt32(parts[1]) };
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static Dictionary<string, Moves> ReadMoves(string sourceDirectory)
        {
            const string FileName = "/Moves.csv";
            Dictionary<string, Moves> coll = new Dictionary<string, Moves>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new Moves() { Speed = Convert.ToDouble(parts[1]), Basic = Convert.ToBoolean(parts[2]), Jump = Convert.ToBoolean(parts[3]), Climb = Convert.ToBoolean(parts[4]) };
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static Dictionary<string, Range> ReadRange(string sourceDirectory)
        {
            const string FileName = "/Range.csv";
            Dictionary<string, Range> coll = new Dictionary<string, Range>();

            if (!File.Exists(sourceDirectory + FileName))
            {
                Console.WriteLine(sourceDirectory + FileName + " not found");
                return coll;
            }

            var enReader = File.OpenText(sourceDirectory + FileName);

            // Skip the header
            enReader.ReadLine();

            // Process the contents
            var line = enReader.ReadLine();
            while (line.Length > 0)
            {
                var parts = line.Split(',');

                var obj = new Range() { Projectile = parts[1], IntervalMin = Convert.ToInt32(parts[2]), IntervalMax = Convert.ToInt32(parts[3]), Radius = Convert.ToInt32(parts[4]) };
                coll.Add(parts[0], obj);
            }

            return coll;
        }

        public static bool ApplySource(BehaviorPack pack, string sourceDirectory)
        {
            if (!Directory.Exists(sourceDirectory))
            {
                Console.WriteLine(sourceDirectory + " not found.");
                return false;
            }

            // Read the csv fiels into memory
            var entities = ReadEntities(sourceDirectory);
            var attackBehaviors = ReadAttackBehavior(sourceDirectory);
            var families = ReadFamilies(sourceDirectory);
            var filters = ReadFilters(sourceDirectory);
            var filtertests = ReadFilterTest(sourceDirectory);
            var health = ReadHealth(sourceDirectory);
            var melee = ReadMelee(sourceDirectory);
            var moves = ReadMoves(sourceDirectory);
            var range = ReadRange(sourceDirectory);

            foreach (var pair in entities)
            {
                if (!pack.Entities.Instances.ContainsKey(pair.Key))
                {
                    Console.WriteLine("Unable to find entity names " + pair.Key + " in behavior pack");
                    continue;
                }

                var pEntity = pack.Entities.Instances[pair.Key];

                if (!pEntity.minecraftEntity.Components.ContainsKey("minecraft:behavior.nearest_attackable_target"))
                {
                    pEntity.minecraftEntity.Components.Add("minecraft:behavior.nearest_attackable_target", new MCDataStructures.Minecraft_behavior_nearest_attackable_target());
                }

                var bnat = pEntity.minecraftEntity.Components["minecraft:behavior.nearest_attackable_target"] as MCDataStructures.Minecraft_behavior_nearest_attackable_target;
                bnat.
            }

            return true;
        }
    }
}
