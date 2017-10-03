using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exporter
{
    class Program
    {
        static Entity MakeDefault()
        {
            Entity entity = new Entity();

            entity.minecraftEntity.format_version = "1.2";
            entity.minecraftEntity.components.minecraft_addrider = new MCDataStructures.Components.Minecraft_addrider();
            entity.minecraftEntity.components.minecraft_ageable = new MCDataStructures.Components.Minecraft_ageable();
            entity.minecraftEntity.components.minecraft_angry = new MCDataStructures.Components.Minecraft_angry();
            entity.minecraftEntity.components.minecraft_behavior_avoid_mob_type = new MCDataStructures.Components.Minecraft_behavior_avoid_mob_type();
            entity.minecraftEntity.components.minecraft_behavior_beg = new MCDataStructures.Components.Minecraft_behavior_beg();
            entity.minecraftEntity.components.minecraft_behavior_break_door = new MCDataStructures.Components.Minecraft_behavior_break_door();
            entity.minecraftEntity.components.minecraft_behavior_breed = new MCDataStructures.Components.Minecraft_behavior_breed();
            entity.minecraftEntity.components.minecraft_behavior_charge_attack = new MCDataStructures.Components.Minecraft_behavior_charge_attack();
            entity.minecraftEntity.components.minecraft_behavior_controlled_by_player = new MCDataStructures.Components.Minecraft_behavior_controlled_by_player();
            entity.minecraftEntity.components.minecraft_behavior_defend_village_target = new MCDataStructures.Components.Minecraft_behavior_defend_village_target();
            entity.minecraftEntity.components.minecraft_behavior_door_interact = new MCDataStructures.Components.Minecraft_behavior_door_interact();
            entity.minecraftEntity.components.minecraft_behavior_dragonchargeplayer = new MCDataStructures.Components.Minecraft_behavior_dragonchargeplayer();
            entity.minecraftEntity.components.minecraft_behavior_dragondeath = new MCDataStructures.Components.Minecraft_behavior_dragondeath();
            entity.minecraftEntity.components.minecraft_behavior_dragonflaming = new MCDataStructures.Components.Minecraft_behavior_dragonflaming();
            entity.minecraftEntity.components.minecraft_behavior_dragonholdingpattern = new MCDataStructures.Components.Minecraft_behavior_dragonholdingpattern();
            entity.minecraftEntity.components.minecraft_behavior_dragonlanding = new MCDataStructures.Components.Minecraft_behavior_dragonlanding();
            entity.minecraftEntity.components.minecraft_behavior_dragonscanning = new MCDataStructures.Components.Minecraft_behavior_dragonscanning();
            entity.minecraftEntity.components.minecraft_behavior_dragonstrafeplayer = new MCDataStructures.Components.Minecraft_behavior_dragonstrafeplayer();
            entity.minecraftEntity.components.Minecraft_behavior_dragontakeoff = new MCDataStructures.Components.Minecraft_behavior_dragontakeoff();
            entity.minecraftEntity.components.minecraft_behavior_eat_block = new MCDataStructures.Components.Minecraft_behavior_eat_block();
            entity.minecraftEntity.components.minecraft_behavior_enderman_leave_block = new MCDataStructures.Components.Minecraft_behavior_enderman_leave_block();
            entity.minecraftEntity.components.minecraft_behavior_enderman_take_block = new MCDataStructures.Components.Minecraft_behavior_enderman_take_block();
            entity.minecraftEntity.components.minecraft_behavior_find_mount = new MCDataStructures.Components.Minecraft_behavior_find_mount();
            entity.minecraftEntity.components.minecraft_behavior_flee_sun = new MCDataStructures.Components.Minecraft_behavior_flee_sun();
            entity.minecraftEntity.components.minecraft_behavior_float = new MCDataStructures.Components.Minecraft_behavior_float();
            entity.minecraftEntity.components.minecraft_behavior_float_wander = new MCDataStructures.Components.Minecraft_behavior_float_wander();
            entity.minecraftEntity.components.minecraft_behavior_follow_caravan = new MCDataStructures.Components.Minecraft_behavior_follow_caravan();
            entity.minecraftEntity.components.minecraft_behavior_follow_mob = new MCDataStructures.Components.Minecraft_behavior_follow_mob();
            entity.minecraftEntity.components.minecraft_behavior_follow_owner = new MCDataStructures.Components.Minecraft_behavior_follow_owner();
            entity.minecraftEntity.components.minecraft_behavior_follow_parent = new MCDataStructures.Components.Minecraft_behavior_follow_parent();
            entity.minecraftEntity.components.minecraft_behavior_guardian_attack = new MCDataStructures.Components.Minecraft_behavior_guardian_attack();
            entity.minecraftEntity.components.minecraft_behavior_harvest_farm_block = new MCDataStructures.Components.Minecraft_behavior_harvest_farm_block();
            entity.minecraftEntity.components.minecraft_behavior_hurt_by_target = new MCDataStructures.Components.Minecraft_behavior_hurt_by_target();
            entity.minecraftEntity.components.minecraft_behavior_leap_at_target = new MCDataStructures.Components.Minecraft_behavior_leap_at_target();
            entity.minecraftEntity.components.minecraft_behavior_look_at_entity = new MCDataStructures.Components.Minecraft_behavior_look_at_entity();
            entity.minecraftEntity.components.minecraft_behavior_look_at_player = new MCDataStructures.Components.Minecraft_behavior_look_at_player();
            entity.minecraftEntity.components.minecraft_behavior_look_at_target = new MCDataStructures.Components.Minecraft_behavior_look_at_target();
            entity.minecraftEntity.components.minecraft_behavior_look_at_trading_player = new MCDataStructures.Components.Minecraft_behavior_look_at_trading_player();
            entity.minecraftEntity.components.minecraft_behavior_make_love = new MCDataStructures.Components.Minecraft_behavior_make_love();
            entity.minecraftEntity.components.minecraft_behavior_melee_attack = new MCDataStructures.Components.Minecraft_behavior_melee_attack();
            entity.minecraftEntity.components.minecraft_behavior_mount_pathing = new MCDataStructures.Components.Minecraft_behavior_mount_pathing();
            entity.minecraftEntity.components.minecraft_behavior_move_indoors = new MCDataStructures.Components.Minecraft_behavior_move_indoors();
            entity.minecraftEntity.components.minecraft_behavior_move_through_village = new MCDataStructures.Components.Minecraft_behavior_move_through_village();
            entity.minecraftEntity.components.minecraft_behavior_move_towards_restriction = new MCDataStructures.Components.Minecraft_behavior_move_towards_restriction();
            entity.minecraftEntity.components.minecraft_behavior_move_towards_target = new MCDataStructures.Components.Minecraft_behavior_move_towards_target();
            entity.minecraftEntity.components.minecraft_behavior_nearest_attackable_target = new MCDataStructures.Components.Minecraft_behavior_nearest_attackable_target();
            entity.minecraftEntity.components.minecraft_behavior_ocelotattack = new MCDataStructures.Components.Minecraft_behavior_ocelotattack();
            entity.minecraftEntity.components.minecraft_behavior_ocelot_sit_on_block = new MCDataStructures.Components.Minecraft_behavior_ocelot_sit_on_block();
            entity.minecraftEntity.components.minecraft_behavior_offer_flower = new MCDataStructures.Components.Minecraft_behavior_offer_flower();
            entity.minecraftEntity.components.minecraft_behavior_open_door = new MCDataStructures.Components.Minecraft_behavior_open_door();
            entity.minecraftEntity.components.minecraft_behavior_owner_hurt_by_target = new MCDataStructures.Components.Minecraft_behavior_owner_hurt_by_target();
            entity.minecraftEntity.components.minecraft_behavior_owner_hurt_target = new MCDataStructures.Components.Minecraft_behavior_owner_hurt_target();
            entity.minecraftEntity.components.minecraft_behavior_panic = new MCDataStructures.Components.Minecraft_behavior_panic();
            entity.minecraftEntity.components.minecraft_behavior_peek = new MCDataStructures.Components.Minecraft_behavior_peek();
            entity.minecraftEntity.components.minecraft_behavior_pickup_items = new MCDataStructures.Components.Minecraft_behavior_pickup_items();
            entity.minecraftEntity.components.minecraft_behavior_play = new MCDataStructures.Components.Minecraft_behavior_play();
            entity.minecraftEntity.components.minecraft_behavior_player_ride_tamed = new MCDataStructures.Components.Minecraft_behavior_player_ride_tamed();
            entity.minecraftEntity.components.minecraft_behavior_raid_garden = new MCDataStructures.Components.Minecraft_behavior_raid_garden();
            entity.minecraftEntity.components.minecraft_behavior_random_fly = new MCDataStructures.Components.Minecraft_behavior_random_fly();
            entity.minecraftEntity.components.minecraft_behavior_random_look_around = new MCDataStructures.Components.Minecraft_behavior_random_look_around();
            entity.minecraftEntity.components.minecraft_behavior_random_stroll = new MCDataStructures.Components.Minecraft_behavior_random_stroll();
            entity.minecraftEntity.components.minecraft_behavior_ranged_attack = new MCDataStructures.Components.Minecraft_behavior_ranged_attack();
            entity.minecraftEntity.components.minecraft_behavior_receive_love = new MCDataStructures.Components.Minecraft_behavior_receive_love();
            entity.minecraftEntity.components.minecraft_behavior_restrict_open_door = new MCDataStructures.Components.Minecraft_behavior_restrict_open_door();
            entity.minecraftEntity.components.minecraft_behavior_restrict_sun = new MCDataStructures.Components.Minecraft_behavior_restrict_sun();
            entity.minecraftEntity.components.minecraft_behavior_run_around_like_crazy = new MCDataStructures.Components.Minecraft_behavior_run_around_like_crazy();
            entity.minecraftEntity.components.minecraft_behavior_send_event = new MCDataStructures.Components.Minecraft_behavior_send_event();
            entity.minecraftEntity.components.minecraft_behavior_share_items = new MCDataStructures.Components.Minecraft_behavior_share_items();
            entity.minecraftEntity.components.minecraft_behavior_silverfish_merge_with_stone = new MCDataStructures.Components.Minecraft_behavior_silverfish_merge_with_stone();
            entity.minecraftEntity.components.minecraft_behavior_silverfish_wake_up_friends = new MCDataStructures.Components.Minecraft_behavior_silverfish_wake_up_friends();
            entity.minecraftEntity.components.minecraft_behavior_skeleton_horse_trap = new MCDataStructures.Components.Minecraft_behavior_skeleton_horse_trap();
            entity.minecraftEntity.components.minecraft_behavior_slime_attack = new MCDataStructures.Components.Minecraft_behavior_slime_attack();
            entity.minecraftEntity.components.minecraft_behavior_slime_float = new MCDataStructures.Components.Minecraft_behavior_slime_float();
            entity.minecraftEntity.components.minecraft_behavior_slime_keep_on_jumping = new MCDataStructures.Components.Minecraft_behavior_slime_keep_on_jumping();
            entity.minecraftEntity.components.minecraft_behavior_slime_random_direction = new MCDataStructures.Components.Minecraft_behavior_slime_random_direction();
            entity.minecraftEntity.components.minecraft_behavior_squid_dive = new MCDataStructures.Components.Minecraft_behavior_squid_dive();
            entity.minecraftEntity.components.minecraft_behavior_squid_flee = new MCDataStructures.Components.Minecraft_behavior_squid_flee();
            entity.minecraftEntity.components.minecraft_behavior_squid_idle = new MCDataStructures.Components.Minecraft_behavior_squid_idle();
            entity.minecraftEntity.components.minecraft_behavior_squid_move_away_from_ground = new MCDataStructures.Components.Minecraft_behavior_squid_move_away_from_ground();
            entity.minecraftEntity.components.minecraft_behavior_squid_out_of_water = new MCDataStructures.Components.Minecraft_behavior_squid_out_of_water();
            entity.minecraftEntity.components.minecraft_behavior_stay_while_sitting = new MCDataStructures.Components.Minecraft_behavior_stay_while_sitting();
            entity.minecraftEntity.components.minecraft_behavior_stomp_attack = new MCDataStructures.Components.Minecraft_behavior_stomp_attack();
            entity.minecraftEntity.components.minecraft_behavior_summon_entity = new MCDataStructures.Components.Minecraft_behavior_summon_entity();
            entity.minecraftEntity.components.minecraft_behavior_swell = new MCDataStructures.Components.Minecraft_behavior_swell();
            entity.minecraftEntity.components.minecraft_behavior_take_flower = new MCDataStructures.Components.Minecraft_behavior_take_flower();
            entity.minecraftEntity.components.minecraft_behavior_tempt = new MCDataStructures.Components.Minecraft_behavior_tempt();
            entity.minecraftEntity.components.minecraft_behavior_trade_with_player = new MCDataStructures.Components.Minecraft_behavior_trade_with_player();
            entity.minecraftEntity.components.minecraft_behavior_vex_copy_owner_target = new MCDataStructures.Components.Minecraft_behavior_vex_copy_owner_target();
            entity.minecraftEntity.components.minecraft_behavior_vex_random_move = new MCDataStructures.Components.Minecraft_behavior_vex_random_move();
            entity.minecraftEntity.components.minecraft_behavior_wither_random_attack_pos_goal = new MCDataStructures.Components.Minecraft_behavior_wither_random_attack_pos_goal();
            entity.minecraftEntity.components.minecraft_behavior_wither_target_highest_damage = new MCDataStructures.Components.Minecraft_behavior_wither_target_highest_damage();
            entity.minecraftEntity.components.minecraft_boostable = new MCDataStructures.Components.Minecraft_boostable();
            entity.minecraftEntity.components.minecraft_breathable = new MCDataStructures.Components.Minecraft_breathable();
            entity.minecraftEntity.components.minecraft_breedable = new MCDataStructures.Components.Minecraft_breedable();
            entity.minecraftEntity.components.minecraft_environment_sensor = new MCDataStructures.Components.Minecraft_environment_sensor();
            entity.minecraftEntity.components.minecraft_equippable = new MCDataStructures.Components.Minecraft_equippable();
            entity.minecraftEntity.components.minecraft_explode = new MCDataStructures.Components.Minecraft_explode();
            entity.minecraftEntity.components.minecraft_healable = new MCDataStructures.Components.Minecraft_healable();
            entity.minecraftEntity.components.minecraft_inventory = new MCDataStructures.Components.Minecraft_inventory();
            entity.minecraftEntity.components.minecraft_item_hopper = new MCDataStructures.Components.Minecraft_item_hopper();
            entity.minecraftEntity.components.minecraft_jump_dynamic = new MCDataStructures.Components.Minecraft_jump_dynamic();
            entity.minecraftEntity.components.minecraft_jump_static = new MCDataStructures.Components.Minecraft_jump_static();
            entity.minecraftEntity.components.minecraft_leashable = new MCDataStructures.Components.Minecraft_leashable();
            entity.minecraftEntity.components.Minecraft_lookat = new MCDataStructures.Components.Minecraft_lookat();
            entity.minecraftEntity.components.minecraft_movement_basic = new MCDataStructures.Components.Minecraft_movement_basic();
            entity.minecraftEntity.components.minecraft_movement_fly = new MCDataStructures.Components.Minecraft_movement_fly();
            entity.minecraftEntity.components.minecraft_movement_jump = new MCDataStructures.Components.Minecraft_movement_jump();
            entity.minecraftEntity.components.minecraft_movement_skip = new MCDataStructures.Components.Minecraft_movement_skip();
            entity.minecraftEntity.components.minecraft_movement_sway = new MCDataStructures.Components.Minecraft_movement_sway();
            entity.minecraftEntity.components.minecraft_nameable = new MCDataStructures.Components.Minecraft_nameable();
            entity.minecraftEntity.components.minecraft_navigation_climb = new MCDataStructures.Components.Minecraft_navigation_climb();
            entity.minecraftEntity.components.minecraft_navigation_float = new MCDataStructures.Components.Minecraft_navigation_float();
            entity.minecraftEntity.components.minecraft_navigation_fly = new MCDataStructures.Components.Minecraft_navigation_fly();
            entity.minecraftEntity.components.minecraft_navigation_swim = new MCDataStructures.Components.Minecraft_navigation_swim();
            entity.minecraftEntity.components.minecraft_navigation_walk = new MCDataStructures.Components.Minecraft_navigation_walk();
            entity.minecraftEntity.components.minecraft_peek = new MCDataStructures.Components.Minecraft_peek();
            entity.minecraftEntity.components.minecraft_projectile = new MCDataStructures.Components.Minecraft_projectile();
            entity.minecraftEntity.components.minecraft_rail_movement = new MCDataStructures.Components.Minecraft_rail_movement();
            entity.minecraftEntity.components.minecraft_rail_sensor = new MCDataStructures.Components.Minecraft_rail_sensor();
            entity.minecraftEntity.components.minecraft_rideable = new MCDataStructures.Components.Minecraft_rideable();
            entity.minecraftEntity.components.minecraft_scale_by_age = new MCDataStructures.Components.Minecraft_scale_by_age();
            entity.minecraftEntity.components.minecraft_shareables = new MCDataStructures.Components.Minecraft_shareables();
            entity.minecraftEntity.components.minecraft_shooter = new MCDataStructures.Components.Minecraft_shooter();
            entity.minecraftEntity.components.minecraft_sittable = new MCDataStructures.Components.Minecraft_sittable();
            entity.minecraftEntity.components.minecraft_spawn_entity = new MCDataStructures.Components.Minecraft_spawn_entity();
            entity.minecraftEntity.components.minecraft_tameable = new MCDataStructures.Components.Minecraft_tameable();
            entity.minecraftEntity.components.minecraft_tamemount = new MCDataStructures.Components.Minecraft_tamemount();
            entity.minecraftEntity.components.minecraft_target_nearby_sensor = new MCDataStructures.Components.Minecraft_target_nearby_sensor();
            entity.minecraftEntity.components.minecraft_teleport = new MCDataStructures.Components.Minecraft_teleport();
            entity.minecraftEntity.components.minecraft_tick_world = new MCDataStructures.Components.Minecraft_tick_world();
            entity.minecraftEntity.components.minecraft_timer = new MCDataStructures.Components.Minecraft_timer();
            entity.minecraftEntity.components.minecraft_trade_table = new MCDataStructures.Components.Minecraft_trade_table();
            entity.minecraftEntity.components.minecraft_transformation = new MCDataStructures.Components.Minecraft_transformation();

            return entity;
        }

        static void Main(string[] args)
        {
            var unpacker = Unpacker.Create("C:\\Users\\pamea\\Documents\\Moba\\vanillabehaviorpack-master\\vanillabehaviorpack-master");
            var pack = unpacker.Extract();
            var packer = Packer.Create("Moba", pack);
            packer.Pack("c:\\users\\pamea\\Documents\\MinecraftBehaviorPacks"); 

            string output = JsonConvert.SerializeObject(pack);

            Console.Write(output);

        }
    }
}
