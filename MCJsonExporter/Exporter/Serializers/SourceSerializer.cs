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
            public string FightBackFilterGroup { get; set; }
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
            public int Value { get; set; }
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

        public class FilterGroup
        {
            public string Filter1 { get; set; }
            public string Filter2 { get; set; }
            public string Filter3 { get; set; }
            public string Filter4 { get; set; }
            public string Filter5 { get; set; }
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');
                if (parts[0].Length > 0)
                {
                    Entity entity = new Entity() { Family = parts[1], Health = parts[2], Move = parts[3], Equip = parts[4], Loot = parts[5], Melee = parts[6], Range = parts[7], EnemyFilterGroup = parts[8], FightBackFilterGroup = parts[9] };
                    entities.Add(parts[0].ToLower(), entity);
                }
                line = enReader.ReadLine();
            }

            return entities;
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new Families() { Type1 = parts[1], Type2 = parts[2], Type3 = parts[3], Type4 = parts[4], Type5 = parts[5] };
                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new Filters()
                {
                    AnyAll = parts[1],
                    Test1 = parts[2],
                    Test2 = parts[3],
                    Test3 = parts[4],
                    Test4 = parts[5],
                    Test5 = parts[6]
                };
                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new FilterTest() { Test = parts[1], Subject = parts[2], Operator = parts[3], Value = parts[4]};
                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new Health() { Value = Convert.ToInt32(parts[1]), Max = Convert.ToInt32(parts[2]) };
                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new Melee() { Damage = Convert.ToInt32(parts[1]) };
                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new Moves() { Speed = Convert.ToDouble(parts[1]), Basic = Convert.ToBoolean(parts[2]), Jump = Convert.ToBoolean(parts[3]), Climb = Convert.ToBoolean(parts[4]) };
                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new Range() { Projectile = parts[1], IntervalMin = Convert.ToInt32(parts[2]), IntervalMax = Convert.ToInt32(parts[3]), Radius = Convert.ToInt32(parts[4]) };
                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
            }

            return coll;
        }

        public static Dictionary<string, FilterGroup> ReadFilterGroup(string sourceDirectory)
        {
            const string FileName = "/FilterGroup.csv";
            Dictionary<string, FilterGroup> coll = new Dictionary<string, FilterGroup>();

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
            while (line != null && line.Length > 0)
            {
                var parts = line.ToLower().Split(',');

                var obj = new FilterGroup()
                {
                    Filter1 = parts[1],
                    Filter2 = parts[2],
                    Filter3 = parts[3],
                    Filter4 = parts[4],
                    Filter5 = parts[5]
                };

                coll.Add(parts[0].ToLower(), obj);
                line = enReader.ReadLine();
            }

            return coll;
        }

        public static void JObjToComp(Dictionary<string, object> components)
        {
            if (components.ContainsKey("minecraft:attack")) components["minecraft:attack"] = (components["minecraft:attack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_attack>();
            if (components.ContainsKey("minecraft:spell_effects")) components["minecraft:spell_effects"] = (components["minecraft:spell_effects"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_spell_effects>();
            if (components.ContainsKey("minecraft:strength")) components["minecraft:strength"] = (components["minecraft:strength"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_strength>();
            if (components.ContainsKey("minecraft:health")) components["minecraft:health"] = (components["minecraft:health"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_health>();
            if (components.ContainsKey("minecraft:ambient_sound_interval")) components["minecraft:ambient_sound_interval"] = (components["minecraft:ambient_sound_interval"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_ambient_sound_interval>();
            if (components.ContainsKey("minecraft:behavior")) components["minecraft:behavior.nearest_attackable_target"] = (components["minecraft:behavior.nearest_attackable_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_nearest_attackable_target>();
            if (components.ContainsKey("minecraft:collision_box")) components["minecraft:collision_box"] = (components["minecraft:collision_box"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_collision_box>();
            if (components.ContainsKey("minecraft:color")) components["minecraft:color"] = (components["minecraft:color"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_color>();
            if (components.ContainsKey("minecraft:default_look_angle")) components["minecraft:default_look_angle"] = (components["minecraft:default_look_angle"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_default_look_angle>();
            if (components.ContainsKey("minecraft:equipment")) components["minecraft:equipment"] = (components["minecraft:equipment"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_equipment>();
            if (components.ContainsKey("minecraft:flying_speed")) components["minecraft:flying_speed"] = (components["minecraft:flying_speed"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_flying_speed>();
            if (components.ContainsKey("minecraft:foot_size")) components["minecraft:foot_size"] = (components["minecraft:foot_size"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_foot_size>();
            if (components.ContainsKey("minecraft:friction_modifier")) components["minecraft:friction_modifier"] = (components["minecraft:friction_modifier"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_friction_modifier>();
            if (components.ContainsKey("minecraft:ground_offset")) components["minecraft:ground_offset"] = (components["minecraft:ground_offset"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_ground_offset>();
            if (components.ContainsKey("minecraft:is_dyeable")) components["minecraft:is_dyeable"] = (components["minecraft:is_dyeableminecraft:is_dyeable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_is_dyeable>();
            if (components.ContainsKey("minecraft:item_controllable")) components["minecraft:item_controllable"] = (components["minecraft:item_controllable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_item_controllable>();
            if (components.ContainsKey("minecraft:loot")) components["minecraft:loot"] = (components["minecraft:loot"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_loot>();
            if (components.ContainsKey("minecraft:mark_variant")) components["minecraft:mark_variant"] = (components["minecraft:mark_variant"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_mark_variant>();
            if (components.ContainsKey("minecraft:push_through")) components["minecraft:push_through"] = (components["minecraft:push_through"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_push_through>();
            if (components.ContainsKey("minecraft:scale")) components["minecraft:scale"] = (components["minecraft:scale"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_scale>();
            if (components.ContainsKey("minecraft:sound_volume")) components["minecraft:sound_volume"] = (components["minecraft:sound_volume"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_sound_volume>();
            if (components.ContainsKey("minecraft:type_family")) components["minecraft:type_family"] = (components["minecraft:type_family"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_type_family>();
            if (components.ContainsKey("minecraft:variant")) components["minecraft:variant"] = (components["minecraft:variant"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_variant>();
            if (components.ContainsKey("minecraft:walk_animation_speed")) components["minecraft:walk_animation_speed"] = (components["minecraft:walk_animation_speed"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_walk_animation_speed>();
            if (components.ContainsKey("minecraft:addrider")) components["minecraft:addrider"] = (components["minecraft:addrider"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_addrider>();
            if (components.ContainsKey("minecraft:ageable")) components["minecraft:ageable"] = (components["minecraft:ageable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_ageable>();
            if (components.ContainsKey("minecraft:angry")) components["minecraft:angry"] = (components["minecraft:angry"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_angry>();
            if (components.ContainsKey("minecraft:boostable")) components["minecraft:boostable"] = (components["minecraft:boostable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_boostable>();
            if (components.ContainsKey("minecraft:breathable")) components["minecraft:breathable"] = (components["minecraft:breathable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_breathable>();
            if (components.ContainsKey("minecraft:breedable")) components["minecraft:breedable"] = (components["minecraft:breedable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_breedable>();
            if (components.ContainsKey("minecraft:damage_sensor")) components["minecraft:damage_sensor"] = (components["minecraft:damage_sensor"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_damage_sensor>();
            if (components.ContainsKey("minecraft:environment_sensor")) components["minecraft:environment_sensor"] = (components["minecraft:environment_sensor"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_environment_sensor>();
            if (components.ContainsKey("minecraft:equippable")) components["minecraft:equippable"] = (components["minecraft:equippable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_equippable>();
            if (components.ContainsKey("minecraft:explode")) components["minecraft:explode"] = (components["minecraft:explode"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_explode>();
            if (components.ContainsKey("minecraft:healable")) components["minecraft:healable"] = (components["minecraft:healable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_healable>();
            if (components.ContainsKey("minecraft:identity")) components["minecraft:identity"] = (components["minecraft:identity"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_identity>();
            if (components.ContainsKey("minecraft:interact")) components["minecraft:interact"] = (components["minecraft:interact"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_interact>();
            if (components.ContainsKey("minecraft:inventory")) components["minecraft:inventory"] = (components["minecraft:inventory"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_inventory>();
            if (components.ContainsKey("minecraft:leashable")) components["minecraft:leashable"] = (components["minecraft:leashable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_leashable>();
            if (components.ContainsKey("minecraft:lookat")) components["minecraft:lookat"] = (components["minecraft:lookat"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_lookat>();
            if (components.ContainsKey("minecraft:movement")) components["minecraft:movement"] = (components["minecraft:movement"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_movement>();
            if (components.ContainsKey("minecraft:movement_basic")) components["minecraft:movement_basic"] = (components["minecraft:movement_basic"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_movement_basic>();
            if (components.ContainsKey("minecraft:movement_fly")) components["minecraft:movement_fly"] = (components["minecraft:movement_fly"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_movement_fly>();
            if (components.ContainsKey("minecraft:movement_jump")) components["minecraft:movement_jump"] = (components["minecraft:movement_jump"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_movement_jump>();
            if (components.ContainsKey("minecraft:movement_skip")) components["minecraft:movement_skip"] = (components["minecraft:movement_skip"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_movement_skip>();
            if (components.ContainsKey("minecraft:movement_sway")) components["minecraft:movement_sway"] = (components["minecraft:movement_sway"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_movement_sway>();
            if (components.ContainsKey("minecraft:nameable")) components["minecraft:nameable"] = (components["minecraft:nameable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_nameable>();
            if (components.ContainsKey("minecraft:navigation_climb")) components["minecraft:navigation_climb"] = (components["minecraft:navigation_climb"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_navigation_climb>();
            if (components.ContainsKey("minecraft:navigation_float")) components["minecraft:navigation_float"] = (components["minecraft:navigation_float"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_navigation_float>();
            if (components.ContainsKey("minecraft:navigation_fly")) components["minecraft:navigation_fly"] = (components["minecraft:navigation_fly"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_navigation_fly>();
            if (components.ContainsKey("minecraft:navigation_swim")) components["minecraft:navigation_swim"] = (components["minecraft:navigation_swim"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_navigation_swim>();
            if (components.ContainsKey("minecraft:navigation_walk")) components["minecraft:navigation_walk"] = (components["minecraft:navigation_walk"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_navigation_walk>();
            if (components.ContainsKey("minecraft:peek")) components["minecraft:peek"] = (components["minecraft:peek"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_peek>();
            if (components.ContainsKey("minecraft:physics")) components["minecraft:physics"] = (components["minecraft:physics"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_physics>();
            if (components.ContainsKey("minecraft:projectile")) components["minecraft:projectile"] = (components["minecraft:projectile"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_projectile>();
            if (components.ContainsKey("minecraft:rail_movement")) components["minecraft:rail_movement"] = (components["minecraft:rail_movement"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_rail_movement>();
            if (components.ContainsKey("minecraft:rail_sensor")) components["minecraft:rail_sensor"] = (components["minecraft:rail_sensor"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_rail_sensor>();
            if (components.ContainsKey("minecraft:rideable")) components["minecraft:rideable"] = (components["minecraft:rideable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_rideable>();
            if (components.ContainsKey("minecraft:scale_by_age")) components["minecraft:scale_by_age"] = (components["minecraft:scale_by_age"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_scale_by_age>();
            if (components.ContainsKey("minecraft:shareables")) components["minecraft:shareables"] = (components["minecraft:shareables"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_shareables>();
            if (components.ContainsKey("minecraft:shooter")) components["minecraft:shooter"] = (components["minecraft:shooter"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_shooter>();
            if (components.ContainsKey("minecraft:sittable")) components["minecraft:sittable"] = (components["minecraft:sittable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_sittable>();
            if (components.ContainsKey("minecraft:spawn_entity")) components["minecraft:spawn_entity"] = (components["minecraft:spawn_entity"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_spawn_entity>();
            if (components.ContainsKey("minecraft:tameable")) components["minecraft:tameable"] = (components["minecraft:tameable"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_tameable>();
            if (components.ContainsKey("minecraft:tamemount")) components["minecraft:tamemount"] = (components["minecraft:tamemount"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_tamemount>();
            if (components.ContainsKey("minecraft:target_nearby_sensor")) components["minecraft:target_nearby_sensor"] = (components["minecraft:target_nearby_sensor"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_target_nearby_sensor>();
            if (components.ContainsKey("minecraft:teleport")) components["minecraft:teleport"] = (components["minecraft:teleport"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_teleport>();
            if (components.ContainsKey("minecraft:tick_world")) components["minecraft:tick_world"] = (components["minecraft:tick_world"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_tick_world>();
            if (components.ContainsKey("minecraft:timer")) components["minecraft:timer"] = (components["minecraft:timer"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_timer>();
            if (components.ContainsKey("minecraft:trade_table")) components["minecraft:trade_table"] = (components["minecraft:trade_table"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_trade_table>();
            if (components.ContainsKey("minecraft:transformation")) components["minecraft:transformation"] = (components["minecraft:trade_table"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_transformation>();
            if (components.ContainsKey("minecraft:behavior_avoid_mob_type")) components["minecraft:behavior_avoid_mob_type"] = (components["minecraft:behavior_avoid_mob_type"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_avoid_mob_type>();
            if (components.ContainsKey("minecraft:behavior_beg")) components["minecraft:behavior_beg"] = (components["minecraft:behavior_beg"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_beg>();
            if (components.ContainsKey("minecraft:behavior_break_door")) components["minecraft:behavior_break_door"] = (components["minecraft:behavior_break_door"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_break_door>();
            if (components.ContainsKey("minecraft:behavior_breed")) components["minecraft:behavior_breed"] = (components["minecraft:behavior_breedminecraft:behavior_breed"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_breed>();
            if (components.ContainsKey("minecraft:behavior_charge_attack")) components["minecraft:behavior_charge_attack"] = (components["minecraft:behavior_charge_attack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_charge_attack>();
            if (components.ContainsKey("minecraft:behavior_controlled_by_player")) components["minecraft:behavior_controlled_by_player"] = (components["minecraft:behavior_controlled_by_player"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_controlled_by_player>();
            if (components.ContainsKey("minecraft:behavior_defend_village_target")) components["minecraft:behavior_defend_village_target"] = (components["minecraft:behavior_defend_village_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_defend_village_target>();
            if (components.ContainsKey("minecraft:behavior_door_interact")) components["minecraft:behavior_door_interact"] = (components["minecraft:behavior_door_interact"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_door_interact>();
            if (components.ContainsKey("minecraft:behavior_dragonchargeplayer")) components["minecraft:behavior_dragonchargeplayer"] = (components["minecraft:behavior_dragonchargeplayer"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragonchargeplayer>();
            if (components.ContainsKey("minecraft:behavior_dragondeath")) components["minecraft:behavior_dragondeath"] = (components["minecraft:behavior_dragondeath"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragondeath>();
            if (components.ContainsKey("minecraft:behavior_dragonflaming")) components["minecraft:behavior_dragonflaming"] = (components["minecraft:behavior_dragonflaming"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragonflaming>();
            if (components.ContainsKey("minecraft:behavior_dragonholdingpattern")) components["minecraft:behavior_dragonholdingpattern"] = (components["minecraft:behavior_dragonholdingpattern"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragonholdingpattern>();
            if (components.ContainsKey("minecraft:behavior_dragonlanding")) components["minecraft:behavior_dragonlanding"] = (components["minecraft:behavior_dragonlanding"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragonlanding>();
            if (components.ContainsKey("minecraft:behavior_dragonscanning")) components["minecraft:behavior_dragonscanning"] = (components["minecraft:behavior_dragonscanning"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragonscanning>();
            if (components.ContainsKey("minecraft:behavior_dragonstrafeplayer")) components["minecraft:behavior_dragonstrafeplayer"] = (components["minecraft:behavior_dragonstrafeplayer"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragonstrafeplayer>();
            if (components.ContainsKey("minecraft:behavior_dragontakeoff")) components["minecraft:behavior_dragontakeoff"] = (components["minecraft:behavior_dragontakeoff"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_dragontakeoff>();
            if (components.ContainsKey("minecraft:behavior_eat_block")) components["minecraft:behavior_eat_block"] = (components["minecraft:behavior_eat_blockminecraft:behavior_eat_block"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_eat_block>();
            if (components.ContainsKey("minecraft:behavior_enderman_leave_block")) components["minecraft:behavior_enderman_leave_block"] = (components["minecraft:behavior_enderman_leave_block"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_enderman_leave_block>();
            if (components.ContainsKey("minecraft:behavior_enderman_take_block")) components["minecraft:behavior_enderman_take_block"] = (components["minecraft:behavior_enderman_take_block"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_enderman_take_block>();
            if (components.ContainsKey("minecraft:behavior_find_mount")) components["minecraft:behavior_find_mount"] = (components["minecraft:behavior_find_mount"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_find_mount>();
            if (components.ContainsKey("minecraft:behavior_flee_sun")) components["minecraft:behavior_flee_sun"] = (components["minecraft:behavior_flee_sun"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_flee_sun>();
            if (components.ContainsKey("minecraft:behavior_float")) components["minecraft:behavior_float"] = (components["minecraft:behavior_float"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_float>();
            if (components.ContainsKey("minecraft:behavior_float_wander")) components["minecraft:behavior_float_wander"] = (components["minecraft:behavior_float_wander"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_float_wander>();
            if (components.ContainsKey("minecraft:behavior_follow_caravan")) components["minecraft:behavior_follow_caravan"] = (components["minecraft:behavior_follow_caravan"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_follow_caravan>();
            if (components.ContainsKey("minecraft:behavior_follow_mob")) components["minecraft:behavior_follow_mob"] = (components["minecraft:behavior_follow_mob"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_follow_mob>();
            if (components.ContainsKey("minecraft:behavior_follow_owner")) components["minecraft:behavior_follow_owner"] = (components["minecraft:behavior_follow_mob"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_follow_owner>();
            if (components.ContainsKey("minecraft:behavior_follow_parent")) components["minecraft:behavior_follow_parent"] = (components["minecraft:behavior_follow_parent"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_follow_parent>();
            if (components.ContainsKey("minecraft:behavior_guardian_attack")) components["minecraft:behavior_guardian_attack"] = (components["minecraft:behavior_guardian_attack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_guardian_attack>();
            if (components.ContainsKey("minecraft:behavior_harvest_farm_block")) components["minecraft:behavior_harvest_farm_block"] = (components["minecraft:behavior_harvest_farm_block"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_harvest_farm_block>();
            if (components.ContainsKey("minecraft:behavior_hurt_by_target")) components["minecraft:behavior_hurt_by_target"] = (components["minecraft:behavior_hurt_by_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_hurt_by_target>();
            if (components.ContainsKey("minecraft:behavior_leap_at_target")) components["minecraft:behavior_leap_at_target"] = (components["minecraft:behavior_leap_at_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_leap_at_target>();
            if (components.ContainsKey("minecraft:behavior_look_at_entity")) components["minecraft:behavior_look_at_entity"] = (components["minecraft:behavior_look_at_entity"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_look_at_entity>();
            if (components.ContainsKey("minecraft:behavior_look_at_player")) components["minecraft:behavior_look_at_player"] = (components["minecraft:behavior_look_at_player"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_look_at_player>();
            if (components.ContainsKey("minecraft:behavior_look_at_target")) components["minecraft:behavior_look_at_target"] = (components["minecraft:behavior_look_at_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_look_at_target>();
            if (components.ContainsKey("minecraft:behavior_look_at_trading_player")) components["minecraft:behavior_look_at_trading_player"] = (components["minecraft:behavior_look_at_trading_player"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_look_at_trading_player>();
            if (components.ContainsKey("minecraft:behavior_make_love")) components["minecraft:behavior_make_love"] = (components["minecraft:behavior_make_love"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_make_love>();
            if (components.ContainsKey("minecraft:behavior_melee_attack")) components["minecraft:behavior_melee_attack"] = (components["minecraft:behavior_melee_attack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_melee_attack>();
            if (components.ContainsKey("minecraft:behavior_mount_pathing")) components["minecraft:behavior_mount_pathing"] = (components["minecraft:behavior_mount_pathing"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_mount_pathing>();
            if (components.ContainsKey("minecraft:behavior_move_indoors")) components["minecraft:behavior_move_indoors"] = (components["minecraft:behavior_move_indoors"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_move_indoors>();
            if (components.ContainsKey("minecraft:behavior_move_through_village")) components["minecraft:behavior_move_through_village"] = (components["minecraft:behavior_move_through_village"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_move_through_village>();
            if (components.ContainsKey("minecraft:behavior_move_towards_restriction")) components["minecraft:behavior_move_towards_restriction"] = (components["minecraft:behavior_move_towards_restriction"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_move_towards_restriction>();
            if (components.ContainsKey("minecraft:behavior_move_towards_target")) components["minecraft:behavior_move_towards_target"] = (components["minecraft:behavior_move_towards_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_move_towards_target>();
            if (components.ContainsKey("minecraft:behavior_nearest_attackable_target")) components["minecraft:behavior_nearest_attackable_target"] = (components["minecraft:behavior_nearest_attackable_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_nearest_attackable_target>();
            if (components.ContainsKey("minecraft:behavior_ocelot_sit_on_block")) components["minecraft:behavior_ocelot_sit_on_block"] = (components["minecraft:behavior_ocelot_sit_on_block"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_ocelot_sit_on_block>();
            if (components.ContainsKey("minecraft:behavior_ocelotattack")) components["minecraft:behavior_ocelotattack"] = (components["minecraft:behavior_ocelotattack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_ocelotattack>();
            if (components.ContainsKey("minecraft:behavior_offer_flower")) components["minecraft:behavior_offer_flower"] = (components["minecraft:behavior_offer_flower"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_offer_flower>();
            if (components.ContainsKey("minecraft:behavior_open_door")) components["minecraft:behavior_open_door"] = (components["minecraft:behavior_open_door"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_open_door>();
            if (components.ContainsKey("minecraft:behavior_owner_hurt_by_target")) components["minecraft:behavior_owner_hurt_by_target"] = (components["minecraft:behavior_owner_hurt_by_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_owner_hurt_by_target>();
            if (components.ContainsKey("minecraft:behavior_owner_hurt_target")) components["minecraft:behavior_owner_hurt_target"] = (components["minecraft:behavior_owner_hurt_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_owner_hurt_target>();
            if (components.ContainsKey("minecraft:behavior_panic")) components["minecraft:behavior_panic"] = (components["minecraft:behavior_panic"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_panic>();
            if (components.ContainsKey("minecraft:behavior_peek")) components["minecraft:behavior_peek"] = (components["minecraft:behavior_peek"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_peek>();
            if (components.ContainsKey("minecraft:behavior_pickup_items")) components["minecraft:behavior_pickup_items"] = (components["minecraft:behavior_pickup_items"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_pickup_items>();
            if (components.ContainsKey("minecraft:behavior_play")) components["minecraft:behavior_play"] = (components["minecraft:behavior_play"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_play>();
            if (components.ContainsKey("minecraft:behavior_player_ride_tamed")) components["minecraft:behavior_player_ride_tamed"] = (components["minecraft:behavior_player_ride_tamed"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_player_ride_tamed>();
            if (components.ContainsKey("minecraft:behavior_raid_garden")) components["minecraft:behavior_raid_garden"] = (components["minecraft:behavior_raid_garden"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_raid_garden>();
            if (components.ContainsKey("minecraft:behavior_random_fly")) components["minecraft:behavior_random_fly"] = (components["minecraft:behavior_random_fly"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_random_fly>();
            if (components.ContainsKey("minecraft:behavior_random_look_around")) components["minecraft:behavior_random_look_around"] = (components["minecraft:behavior_random_look_around"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_random_look_around>();
            if (components.ContainsKey("minecraft:behavior_random_stroll")) components["minecraft:behavior_random_stroll"] = (components["minecraft:behavior_random_stroll"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_random_stroll>();
            if (components.ContainsKey("minecraft:behavior_ranged_attack")) components["minecraft:behavior_ranged_attack"] = (components["minecraft:behavior_ranged_attack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_ranged_attack>();
            if (components.ContainsKey("minecraft:behavior_receive_love")) components["minecraft:behavior_receive_love"] = (components["minecraft:behavior_receive_love"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_receive_love>();
            if (components.ContainsKey("minecraft:behavior_restrict_open_door")) components["minecraft:behavior_restrict_open_door"] = (components["minecraft:behavior_restrict_open_door"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_restrict_open_door>();
            if (components.ContainsKey("minecraft:behavior_restrict_sun")) components["minecraft:behavior_restrict_sun"] = (components["minecraft:behavior_restrict_sun"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_restrict_sun>();
            if (components.ContainsKey("minecraft:behavior_run_around_like_crazy")) components["minecraft:behavior_run_around_like_crazy"] = (components["minecraft:behavior_run_around_like_crazy"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_run_around_like_crazy>();
            if (components.ContainsKey("minecraft:behavior_send_event")) components["minecraft:behavior_send_event"] = (components["minecraft:behavior_send_event"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_send_event>();
            if (components.ContainsKey("minecraft:behavior_share_items")) components["minecraft:behavior_share_items"] = (components["minecraft:behavior_share_items"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_share_items>();
            if (components.ContainsKey("minecraft:behavior_silverfish_merge_with_stone")) components["minecraft:behavior_silverfish_merge_with_stone"] = (components["minecraft:behavior_silverfish_merge_with_stone"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_silverfish_merge_with_stone>();
            if (components.ContainsKey("minecraft:behavior_silverfish_wake_up_friends")) components["minecraft:behavior_silverfish_wake_up_friends"] = (components["minecraft:behavior_silverfish_wake_up_friends"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_silverfish_wake_up_friends>();
            if (components.ContainsKey("minecraft:behavior_skeleton_horse_trap")) components["minecraft:behavior_skeleton_horse_trap"] = (components["minecraft:behavior_skeleton_horse_trap"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_skeleton_horse_trap>();
            if (components.ContainsKey("minecraft:behavior_slime_attack")) components["minecraft:behavior_slime_attack"] = (components["minecraft:behavior_slime_attack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_slime_attack>();
            if (components.ContainsKey("minecraft:behavior_slime_float")) components["minecraft:behavior_slime_float"] = (components["minecraft:behavior_slime_float"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_slime_float>();
            if (components.ContainsKey("minecraft:behavior_slime_keep_on_jumping")) components["minecraft:behavior_slime_keep_on_jumping"] = (components["minecraft:behavior_slime_keep_on_jumping"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_slime_keep_on_jumping>();
            if (components.ContainsKey("minecraft:behavior_slime_random_direction")) components["minecraft:behavior_slime_random_direction"] = (components["minecraft:behavior_slime_random_direction"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_slime_random_direction>();
            if (components.ContainsKey("minecraft:behavior_squid_dive")) components["minecraft:behavior_squid_dive"] = (components["minecraft:behavior_squid_dive"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_squid_dive>();
            if (components.ContainsKey("minecraft:behavior_squid_flee")) components["minecraft:behavior_squid_flee"] = (components["minecraft:behavior_squid_flee"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_squid_flee>();
            if (components.ContainsKey("minecraft:behavior_squid_idle")) components["minecraft:behavior_squid_idle"] = (components["minecraft:behavior_squid_idle"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_squid_idle>();
            if (components.ContainsKey("minecraft:behavior_squid_move_away_from_ground")) components["minecraft:behavior_squid_move_away_from_ground"] = (components["minecraft:behavior_squid_move_away_from_ground"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_squid_move_away_from_ground>();
            if (components.ContainsKey("minecraft:behavior_squid_out_of_water")) components["minecraft:behavior_squid_out_of_water"] = (components["minecraft:behavior_squid_out_of_water"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_squid_out_of_water>();
            if (components.ContainsKey("minecraft:behavior_stay_while_sitting")) components["minecraft:behavior_stay_while_sitting"] = (components["minecraft:behavior_stay_while_sitting"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_stay_while_sitting>();
            if (components.ContainsKey("minecraft:behavior_stomp_attack")) components["minecraft:behavior_stomp_attack"] = (components["minecraft:behavior_stomp_attack"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_stomp_attack>();
            if (components.ContainsKey("minecraft:behavior_summon_entity")) components["minecraft:behavior_summon_entity"] = (components["minecraft:behavior_summon_entity"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_summon_entity>();
            if (components.ContainsKey("minecraft:behavior_swell")) components["minecraft:behavior_swell"] = (components["minecraft:behavior_swell"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_swell>();
            if (components.ContainsKey("minecraft:behavior_take_flower")) components["minecraft:behavior_take_flower"] = (components["minecraft:behavior_swell"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_take_flower>();
            if (components.ContainsKey("minecraft:behavior_tempt")) components["minecraft:behavior_tempt"] = (components["minecraft:behavior_tempt"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_tempt>();
            if (components.ContainsKey("minecraft:behavior_trade_with_player")) components["minecraft:behavior_trade_with_player"] = (components["minecraft:behavior_trade_with_player"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_trade_with_player>();
            if (components.ContainsKey("minecraft:behavior_vex_copy_owner_target")) components["minecraft:behavior_vex_copy_owner_target"] = (components["minecraft:behavior_vex_copy_owner_target"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_vex_copy_owner_target>();
            if (components.ContainsKey("minecraft:behavior_vex_random_move")) components["minecraft:behavior_vex_random_move"] = (components["minecraft:behavior_vex_random_move"] as Newtonsoft.Json.Linq.JObject)?.ToObject<MCDataStructures.Minecraft_behavior_vex_random_move>();

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
            var families = ReadFamilies(sourceDirectory);
            var filters = ReadFilters(sourceDirectory);
            var filtertests = ReadFilterTest(sourceDirectory);
            var health = ReadHealth(sourceDirectory);
            var melee = ReadMelee(sourceDirectory);
            var moves = ReadMoves(sourceDirectory);
            var range = ReadRange(sourceDirectory);
            var filterGroup = ReadFilterGroup(sourceDirectory);

            foreach (var pair in entities)
            {
                if (!pack.Entities.Instances.ContainsKey(pair.Key))
                {
                    Console.WriteLine("Unable to find entity names " + pair.Key + " in behavior pack");
                    continue;
                }

                var pEntity = pack.Entities.Instances[pair.Key];
                //if (pEntity.minecraftEntity.Components != null) JObjToComp(pEntity.minecraftEntity.Components);
                //if (pEntity.minecraftEntity.ComponentGroups != null) JObjToComp(pEntity.minecraftEntity.ComponentGroups);
                pEntity.minecraftEntity.Components = new Dictionary<string, object>();
                pEntity.minecraftEntity.ComponentGroups = null;
                pEntity.minecraftEntity.Events = null;

                {
                    var id = new MCDataStructures.Minecraft_identity();
                    id.ID = "minecraft:" + pair.Key;
                    pEntity.minecraftEntity.Components["minecraft:identifier"] = id;

                }

                {
                    var colBox = new MCDataStructures.Minecraft_collision_box();
                    colBox.Height = 1.5F;
                    colBox.Width = 1;
                    pEntity.minecraftEntity.Components["minecraft:collision_box"] = colBox;
                }

                {
                    pEntity.minecraftEntity.Components["minecraft:navigation.walk"] = new MCDataStructures.Minecraft_navigation_walk();
                    pEntity.minecraftEntity.Components["minecraft:movement.basic"] = new MCDataStructures.Minecraft_movement_basic();
                    pEntity.minecraftEntity.Components["minecraft:jump.static"] = new MCDataStructures.Minecraft_movement_jump();
                    pEntity.minecraftEntity.Components["minecraft:can_climb"] = new MCDataStructures.Minecraft_navigation_climb();
                    pEntity.minecraftEntity.Components["minecraft:physics"] = new MCDataStructures.Minecraft_physics();
                }

                {
                    pEntity.minecraftEntity.Components["minecraft:type_family"] = new MCDataStructures.Minecraft_type_family();

                    var famcomp = pEntity.minecraftEntity.Components["minecraft:type_family"] as MCDataStructures.Minecraft_type_family;
                    var fam = families[pair.Value.Family.ToLower()];
                    famcomp.Family = new List<string>();
                    if (fam.Type1.Length > 0) famcomp.Family.Add(fam.Type1.ToLower());
                    if (fam.Type2.Length > 0) famcomp.Family.Add(fam.Type2.ToLower());
                    if (fam.Type3.Length > 0) famcomp.Family.Add(fam.Type3.ToLower());
                    if (fam.Type4.Length > 0) famcomp.Family.Add(fam.Type4.ToLower());
                    if (fam.Type5.Length > 0) famcomp.Family.Add(fam.Type5.ToLower());
                }

                {
                    var attack = new MCDataStructures.Minecraft_behavior_melee_attack();
                    attack.Priority = 3;
                    attack.speed_multiplier = 1;
                    attack.track_target = false;
                    pEntity.minecraftEntity.Components["minecraft:behavior.melee_attack"] = attack;
                }

                {
                    pEntity.minecraftEntity.Components["minecraft:attack"] = new MCDataStructures.Minecraft_attack();
                    var melcomp = pEntity.minecraftEntity.Components["minecraft:attack"] as MCDataStructures.Minecraft_attack;
                    var mel = melee[pair.Value.Melee.ToLower()];
                    melcomp.Damage = mel.Damage;
                }

                {
                    pEntity.minecraftEntity.Components["minecraft:health"] = new MCDataStructures.Minecraft_health();
                    var helcomp = pEntity.minecraftEntity.Components["minecraft:health"] as MCDataStructures.Minecraft_health;
                    var hel = health[pair.Value.Health.ToLower()];
                    helcomp.Max = hel.Max;
                    helcomp.Value = hel.Value;
                }

                {
                    var mov = moves[pair.Value.Move.ToLower()];
                    pEntity.minecraftEntity.Components["minecraft:movement"] = new MCDataStructures.Minecraft_movement();
                    var movecomp = pEntity.minecraftEntity.Components["minecraft:movement"] as MCDataStructures.Minecraft_movement;
                    movecomp.Value = mov.Speed;
                }

                {
                    pEntity.minecraftEntity.Components["minecraft:behavior.nearest_attackable_target"] = new MCDataStructures.Minecraft_behavior_nearest_attackable_target();
                    var bnatcomp = pEntity.minecraftEntity.Components["minecraft:behavior.nearest_attackable_target"] as MCDataStructures.Minecraft_behavior_nearest_attackable_target;
                    bnatcomp.entity_types = new List<Exporter.EntityTypes>();
                    if (filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter1.Length > 0) bnatcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter1));
                    if (filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter2.Length > 0) bnatcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter2));
                    if (filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter3.Length > 0) bnatcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter3));
                    if (filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter4.Length > 0) bnatcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter4));
                    if (filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter5.Length > 0) bnatcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].EnemyFilterGroup].Filter5));

                    bnatcomp.must_see = false;
                    bnatcomp.must_reach = false;
                    bnatcomp.attack_interval = 1;
                    bnatcomp.must_see_forget_duration = 3;
                    bnatcomp.reselect_targets = true;
                    bnatcomp.within_radius = 2;
                    bnatcomp.Priority = 2;
                }
                {
                    pEntity.minecraftEntity.Components["minecraft:behavior.hurt_by_target"] = new MCDataStructures.Minecraft_behavior_hurt_by_target();
                    var hurtcomp = pEntity.minecraftEntity.Components["minecraft:behavior.hurt_by_target"] as MCDataStructures.Minecraft_behavior_hurt_by_target;
                    hurtcomp.entity_types = new List<Exporter.EntityTypes>();
                    if (filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter1.Length > 0) hurtcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter1));
                    if (filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter2.Length > 0) hurtcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter2));
                    if (filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter3.Length > 0) hurtcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter3));
                    if (filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter4.Length > 0) hurtcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter4));
                    if (filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter5.Length > 0) hurtcomp.entity_types.Add(parseFilters(filters, filtertests, filterGroup[entities[pair.Key.ToLower()].FightBackFilterGroup].Filter5));

                    hurtcomp.alert_same_type = false;
                    hurtcomp.Priority = 2;
                }
            }

            return true;
        }


        public static void addFilters(string anyAll, Exporter.EntityTypes entTypes, Dictionary<string, Filters> filters, Dictionary<string,FilterTest> filterTests, string testName)
        {
            var list = anyAll == "any" ? entTypes.filters.AnyOf : entTypes.filters.AllOf;
            list.Add(new Filter() { Subject = filterTests[testName].Subject, Test = filterTests[testName].Test, Value = filterTests[testName].Value });
        }

        public static Exporter.EntityTypes parseFilters(Dictionary<string, Filters> filters, Dictionary<string, FilterTest> filterTests, string filterName)
        {
            Exporter.EntityTypes entTypes = new Exporter.EntityTypes { max_dist = 128, must_see = false, sprint_speed_multiplier = 1, walk_speed_multiplier = 1 };
            entTypes.filters = new Exporter.EntityTypes.SubSection();
            if (filters[filterName].Test1.Length > 0) addFilters(filters[filterName].AnyAll, entTypes, filters, filterTests, filters[filterName].Test1);
            if (filters[filterName].Test2.Length > 0) addFilters(filters[filterName].AnyAll, entTypes, filters, filterTests, filters[filterName].Test2);
            if (filters[filterName].Test3.Length > 0) addFilters(filters[filterName].AnyAll, entTypes, filters, filterTests, filters[filterName].Test3);
            if (filters[filterName].Test4.Length > 0) addFilters(filters[filterName].AnyAll, entTypes, filters, filterTests, filters[filterName].Test4);
            if (filters[filterName].Test5.Length > 0) addFilters(filters[filterName].AnyAll, entTypes, filters, filterTests, filters[filterName].Test5);

            if (entTypes.filters.AllOf.Count == 0) entTypes.filters.AllOf = null;
            if (entTypes.filters.AnyOf.Count == 0) entTypes.filters.AnyOf = null;
            return entTypes;
        }
    }
}
