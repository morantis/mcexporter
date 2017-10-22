using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    public class Component
    {

        public static Component Create(string key)
        {
            if (key.Equals("minecraft:attack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures.Minecraft_attack() }
            if (key.Equals("minecraft:spell_effects", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures.Minecraft_spell_effects() }
            if (key.Equals("minecraft:strength", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures.Minecraft_strength() }
            if (key.Equals("minecraft:ambient_sound_interval", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures.Minecraft_ambient_sound_interval() }
            //if (key.Equals("minecraft:collision_box", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:color", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:default_look_angle", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:equipment", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:flying_speed", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:foot_size", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:friction_modifier", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:ground_offset", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:is_dyeable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:item_controllable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:loot", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:mark_variant", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:push_through", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:scale", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:sound_volume", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:type_family", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:variant", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:walk_animation_speed", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:addrider", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:ageable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:angry", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:boostable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:breathable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:breedable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:damage_sensor", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:environment_sensor", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:equippable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:explode", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:healable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:identity", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:interact", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:inventory", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:leashable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:lookat", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:movement_basic", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:movement_fly", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:movement_jump", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:movement_skip", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:movement_sway", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:nameable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:navigation_climb", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:navigation_float", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:navigation_fly", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:navigation_swim", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:navigation_walk", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:peek", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:physics", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:projectile", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:rail_movement", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:rail_sensor", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:rideable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:scale_by_age", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:shareables", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:shooter", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:sittable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:spawn_entity", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:tameable", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:tamemount", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:target_nearby_sensor", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:teleport", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:tick_world", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:timer", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:trade_table", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:transformation", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_avoid_mob_type", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_beg", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_break_door", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_breed", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_charge_attack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_controlled_by_player", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_defend_village_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_door_interact", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragonchargeplayer", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragondeath", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragonflaming", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragonholdingpattern", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragonlanding", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragonscanning", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragonstrafeplayer", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_dragontakeoff", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_eat_block", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_enderman_leave_block", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_enderman_take_block", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_find_mount", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_flee_sun", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_float", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_float_wander", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_follow_caravan", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_follow_mob", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_follow_owner", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_follow_parent", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_guardian_attack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_harvest_farm_block", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_hurt_by_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_leap_at_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_look_at_entity", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_look_at_player", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_look_at_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_look_at_trading_player", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_make_love", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_melee_attack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_mount_pathing", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_move_indoors", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_move_through_village", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_move_towards_restriction", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_move_towards_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_nearest_attackable_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_ocelot_sit_on_block", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_ocelotattack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_offer_flower", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_open_door", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_owner_hurt_by_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_owner_hurt_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_panic", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_peek", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_pickup_items", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_play", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_player_ride_tamed", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_raid_garden", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_random_fly", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_random_look_around", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_random_stroll", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_ranged_attack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_receive_love", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_restrict_open_door", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_restrict_sun", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_run_around_like_crazy", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_send_event", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_share_items", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_silverfish_merge_with_stone", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_silverfish_wake_up_friends", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_skeleton_horse_trap", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_slime_attack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_slime_float", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_slime_keep_on_jumping", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_slime_random_direction", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_squid_dive", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_squid_flee", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_squid_idle", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_squid_move_away_from_ground", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_squid_out_of_water", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_stay_while_sitting", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_stomp_attack", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_summon_entity", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_swell", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_take_flower", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_tempt", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_trade_with_player", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_vex_copy_owner_target", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_vex_random_move", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_wither_random_attack_pos_goal", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }
            //if (key.Equals("minecraft:behavior_wither_target_highest_damage", StringComparison.InvariantCultureIgnoreCase){ return new MCDataStructures }


            return new Component();
        }

        public static implicit operator Component(bool value)
        {
            return new PoorlyImplementedBooleanProperty() { Value = value };
        }
    }

}
