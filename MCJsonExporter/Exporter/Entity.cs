using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    public class Entity
    {
        [JsonIgnore]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "minecraft:entity")]
        public MinecraftEntity minecraftEntity { get; set; }
    }

    class SingleArrayAsObject<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<T>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<T>>()[0];
            }
            return token.ToObject<T>();
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

    public class MinecraftEntity
    {
        [JsonProperty(PropertyName = "format_version")]
        public string format_version { get; set; }

        //public class Components
        //{
        //    [JsonProperty(PropertyName = "minecraft:addrider", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_addrider minecraft_addrider { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:ageable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_ageable minecraft_ageable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:angry", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_angry minecraft_angry { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:boostable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_boostable minecraft_boostable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:breathable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_breathable minecraft_breathable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:breedable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_breedable minecraft_breedable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:damage_sensor", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(SingleOrArrayConverter<MCDataStructures.Components.Minecraft_damage_sensor>))]
        //    public List<MCDataStructures.Components.Minecraft_damage_sensor> minecraft_damage_sensor { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:environment_sensor", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_environment_sensor minecraft_environment_sensor { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:equippable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_equippable minecraft_equippable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:explode", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_explode minecraft_explode { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:healable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_healable minecraft_healable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:identifier", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_identity minecraft_identifier { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:interact", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(SingleOrArrayConverter<MCDataStructures.Components.Minecraft_interact>))]
        //    public List<MCDataStructures.Components.Minecraft_interact> minecraft_interact { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:inventory", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_inventory minecraft_inventory { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:item_hopper", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_item_hopper { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:jump_dynamic", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_jump_dynamic { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:jump_static", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_jump_static { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:leashable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_leashable minecraft_leashable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:addMinecraft_lookatrider", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_lookat Minecraft_lookat { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:movement_basic", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_movement_basic minecraft_movement_basic { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:movement_fly", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_movement_fly minecraft_movement_fly { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:movement_jump", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_movement_jump minecraft_movement_jump { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:movement_skip", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_movement_skip minecraft_movement_skip { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:movement_sway", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_movement_sway minecraft_movement_sway { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:nameable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_nameable minecraft_nameable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:navigation_climb", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_navigation_climb minecraft_navigation_climb { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:navigation_float", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_navigation_float minecraft_navigation_float { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:navigation_fly", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_navigation_fly minecraft_navigation_fly { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:navigation_swim", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_navigation_swim minecraft_navigation_swim { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:navigation_walk", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_navigation_walk minecraft_navigation_walk { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:peek", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_peek minecraft_peek { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:physics", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_physics minecraft_physics { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:projectile", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_projectile minecraft_projectile { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:rail_movement", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_rail_movement minecraft_rail_movement { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:rail_sensor", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_rail_sensor minecraft_rail_sensor { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:rideable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_rideable minecraft_rideable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:scale_by_age", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_scale_by_age minecraft_scale_by_age { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:shareables", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_shareables minecraft_shareables { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:shooter", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_shooter minecraft_shooter { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:sittable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_sittable minecraft_sittable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:spawn_entity", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_spawn_entity minecraft_spawn_entity { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:tameable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_tameable minecraft_tameable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:tamemount", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_tamemount minecraft_tamemount { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:target_nearby_sensor", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_target_nearby_sensor minecraft_target_nearby_sensor { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:teleport", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_teleport minecraft_teleport { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:tick_world", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_tick_world minecraft_tick_world { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:timer", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_timer minecraft_timer { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:trade_table", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_trade_table minecraft_trade_table { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:transformation", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_transformation minecraft_transformation { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.avoid_mob_type", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_avoid_mob_type minecraft_behavior_avoid_mob_type { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.beg", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_beg minecraft_behavior_beg { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.break_door", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_break_door minecraft_behavior_break_door { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.breed", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_breed minecraft_behavior_breed { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.charge_attack", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_charge_attack minecraft_behavior_charge_attack { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.controlled_by_player", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_controlled_by_player minecraft_behavior_controlled_by_player { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.defend_village_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_defend_village_target minecraft_behavior_defend_village_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.door_interact", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_door_interact minecraft_behavior_door_interact { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.dragonchargeplayer", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragonchargeplayer minecraft_behavior_dragonchargeplayer { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.dragondeath", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragondeath minecraft_behavior_dragondeath { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.dragonflaming", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragonflaming minecraft_behavior_dragonflaming { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.dragonholdingpattern", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragonholdingpattern minecraft_behavior_dragonholdingpattern { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.dragonlanding", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragonlanding minecraft_behavior_dragonlanding { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.dragonscanning", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragonscanning minecraft_behavior_dragonscanning { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.dragonstrafeplayer", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragonstrafeplayer minecraft_behavior_dragonstrafeplayer { get; set; }

        //    [JsonProperty(PropertyName = "Minecraft_behavior_dragontakeoff", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_dragontakeoff Minecraft_behavior_dragontakeoff { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.eat_block", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_eat_block minecraft_behavior_eat_block { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.enderman_leave_block", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_enderman_leave_block minecraft_behavior_enderman_leave_block { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.enderman_take_block", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_enderman_take_block minecraft_behavior_enderman_take_block { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.find_mount", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_find_mount minecraft_behavior_find_mount { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.flee_sun", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_flee_sun minecraft_behavior_flee_sun { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.float", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_float minecraft_behavior_float { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.float_wander", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_float_wander minecraft_behavior_float_wander { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.follow_caravan", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_follow_caravan minecraft_behavior_follow_caravan { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.follow_mob", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_follow_mob minecraft_behavior_follow_mob { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.follow_owner", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_follow_owner minecraft_behavior_follow_owner { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.follow_parent", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_follow_parent minecraft_behavior_follow_parent { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.guardian_attack", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_guardian_attack minecraft_behavior_guardian_attack { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.harvest_farm_block", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_harvest_farm_block minecraft_behavior_harvest_farm_block { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.hurt_by_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_hurt_by_target minecraft_behavior_hurt_by_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.leap_at_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_leap_at_target minecraft_behavior_leap_at_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.look_at_entity", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_look_at_entity minecraft_behavior_look_at_entity { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.look_at_player", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_look_at_player minecraft_behavior_look_at_player { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.look_at_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_look_at_target minecraft_behavior_look_at_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.look_at_trading_player", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_look_at_trading_player minecraft_behavior_look_at_trading_player { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.make_love", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_make_love minecraft_behavior_make_love { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.melee_attack", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_melee_attack minecraft_behavior_melee_attack { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.mount_pathing", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_mount_pathing minecraft_behavior_mount_pathing { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.move_indoors", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_move_indoors minecraft_behavior_move_indoors { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.move_through_village", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_move_through_village minecraft_behavior_move_through_village { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.move_towards_restriction", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_move_towards_restriction minecraft_behavior_move_towards_restriction { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.move_towards_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_move_towards_target minecraft_behavior_move_towards_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.nearest_attackable_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_nearest_attackable_target minecraft_behavior_nearest_attackable_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.ocelot_sit_on_block", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_ocelot_sit_on_block minecraft_behavior_ocelot_sit_on_block { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.ocelotattack", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_ocelotattack minecraft_behavior_ocelotattack { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.offer_flower", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_offer_flower minecraft_behavior_offer_flower { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.open_door", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_open_door minecraft_behavior_open_door { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.owner_hurt_by_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_owner_hurt_by_target minecraft_behavior_owner_hurt_by_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.owner_hurt_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_owner_hurt_target minecraft_behavior_owner_hurt_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.panic", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_panic minecraft_behavior_panic { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.peek", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_peek minecraft_behavior_peek { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.pickup_items", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_pickup_items minecraft_behavior_pickup_items { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.play", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_play minecraft_behavior_play { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.player_ride_tamed", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_player_ride_tamed minecraft_behavior_player_ride_tamed { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.raid_garden", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_raid_garden minecraft_behavior_raid_garden { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.random_fly", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_random_fly minecraft_behavior_random_fly { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.random_look_around", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_random_look_around minecraft_behavior_random_look_around { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.random_stroll", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_random_stroll minecraft_behavior_random_stroll { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.ranged_attack", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_ranged_attack minecraft_behavior_ranged_attack { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.receive_love", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_receive_love minecraft_behavior_receive_love { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.restrict_open_door", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_restrict_open_door minecraft_behavior_restrict_open_door { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.restrict_sun", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_restrict_sun minecraft_behavior_restrict_sun { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.run_around_like_crazy", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_run_around_like_crazy minecraft_behavior_run_around_like_crazy { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.send_event", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_send_event minecraft_behavior_send_event { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.share_items", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_share_items minecraft_behavior_share_items { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.silverfish_merge_with_stone", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_silverfish_merge_with_stone minecraft_behavior_silverfish_merge_with_stone { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.silverfish_wake_up_friends", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_silverfish_wake_up_friends minecraft_behavior_silverfish_wake_up_friends { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.skeleton_horse_trap", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_skeleton_horse_trap minecraft_behavior_skeleton_horse_trap { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.slime_attack", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_slime_attack minecraft_behavior_slime_attack { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.slime_float", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_slime_float minecraft_behavior_slime_float { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.slime_keep_on_jumping", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_slime_keep_on_jumping minecraft_behavior_slime_keep_on_jumping { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.slime_random_direction", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_slime_random_direction minecraft_behavior_slime_random_direction { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.squid_dive", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_squid_dive minecraft_behavior_squid_dive { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.squid_flee", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_squid_flee minecraft_behavior_squid_flee { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.squid_idle", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_squid_idle minecraft_behavior_squid_idle { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.squid_move_away_from_ground", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_squid_move_away_from_ground minecraft_behavior_squid_move_away_from_ground { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.squid_out_of_water", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_squid_out_of_water minecraft_behavior_squid_out_of_water { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.stay_while_sitting", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_stay_while_sitting minecraft_behavior_stay_while_sitting { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.stomp_attack", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_stomp_attack minecraft_behavior_stomp_attack { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.summon_entity", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_summon_entity minecraft_behavior_summon_entity { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.swell", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_swell minecraft_behavior_swell { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.take_flower", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_take_flower minecraft_behavior_take_flower { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.tempt", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_tempt minecraft_behavior_tempt { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.trade_with_player", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_trade_with_player minecraft_behavior_trade_with_player { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.vex_copy_owner_target", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_vex_copy_owner_target minecraft_behavior_vex_copy_owner_target { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.vex_random_move", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_vex_random_move minecraft_behavior_vex_random_move { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.wither_random_attack_pos_goal", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_wither_random_attack_pos_goal minecraft_behavior_wither_random_attack_pos_goal { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:behavior.wither_target_highest_damage", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Components.Minecraft_behavior_wither_target_highest_damage minecraft_behavior_wither_target_highest_damage { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:ambient_sound_interval", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_ambient_sound_interval minecraft_Ambient_Sound_Interval { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:burns_in_daylight", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Burns_In_Daylight { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:can_climb", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Can_Climb { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:can_fly", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Can_Fly { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:can_power_jump", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Can_Power_Jump { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:collision_box", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_collision_box minecraft_Collision_Box { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:color", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_color minecraft_Color { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:default_look_angle", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_default_look_angle minecraft_Default_Look_Angle { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:equipment", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_equipment minecraft_Equipment { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:fire_immune", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Fire_Immune { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:floats_in_liquid", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Floats_In_Liquid { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:flying_speed", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_flying_speed minecraft_Flying_Speed { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:foot_size", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_foot_size minecraft_Foot_Size { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:friction_modifier", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_friction_modifier minecraft_Friction_Modifier { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:ground_offset", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_ground_offset minecraft_Ground_Offset { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:hurt_when_wet", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Hurt_When_Wet { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:input_ground_controlled", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Input_Ground_Controlled { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_baby", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Baby { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_charged", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Charged { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_chested", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Chested { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_dyeable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_is_dyeable minecraft_Is_Dyeable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_ignited", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Ignited { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_saddled", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Saddled { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_shaking", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Shaking { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_sheared", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Sheared { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_stackable", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Stackable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:is_tamed", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Is_Tamed { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:item_controllable", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_item_controllable minecraft_Item_Controllable { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:loot", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_loot minecraft_Loot { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:mark_variant", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_mark_variant minecraft_Mark_Variant { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:push_through", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_push_through minecraft_Push_Through { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:scale", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_scale minecraft_Scale { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:sound_volume", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_sound_volume minecraft_Sound_Volume { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:type_family", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_type_family minecraft_Type_Family { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:variant", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_variant minecraft_Variant { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:walk_animation_speed", NullValueHandling = NullValueHandling.Ignore)]
        //    public MCDataStructures.Properties.Minecraft_walk_animation_speed minecraft_Walk_Animation_Speed { get; set; }

        //    [JsonProperty(PropertyName = "minecraft:wants_jockey", NullValueHandling = NullValueHandling.Ignore)]
        //    [JsonConverter(typeof(MCDataStructures.Properties.PoorlyImplementedBooleanConverter))]
        //    public MCDataStructures.Properties.PoorlyImplementedBooleanProperty minecraft_Wants_Jockey { get; set; }
        //}


        public bool ShouldSerializeComponentGroups()
        {
            return ComponentGroups?.Count > 0;
        }

        [JsonProperty(PropertyName = "component_groups", NullValueHandling = NullValueHandling.Ignore)]
        //public Dictionary<string, Dictionary<string, MCDataStructures.Component>> ComponentGroups { get; set; }
        public Dictionary<string, object> ComponentGroups { get; set; }

        [JsonProperty(PropertyName = "components")]
        //public Dictionary<string, MCDataStructures.Component> components { get; set; }
        public Dictionary<string, object> components { get; set; }
    }

}
