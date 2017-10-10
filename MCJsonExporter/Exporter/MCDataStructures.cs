using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    public class MCDataStructures
    {
        public class ItemsObj
        {
            [JsonProperty(PropertyName = "table", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string table { get; set; }// JSON Object     Loot table with items to drop on the ground upon successful interaction        
        }

        public class OnDamageFilters
        {
            [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<Filter>))]
            public List<Filter> filters { get; set; }
        }

        public class MinecraftEvent
        {
            [JsonProperty(PropertyName = "event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Event { get; set; }

            [JsonProperty(PropertyName = "target", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Target { get; set; }
        }

        public class Minecraft_attack : Attribute
        {
            // Defines an entity's melee attack and any additional effects on it.
            [JsonProperty(PropertyName = "damage", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] Damage;

            [JsonProperty(PropertyName = "effect_duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Effect_duration { get; set; } // {get; set;} //	0.0	Duration in seconds of the status ailment applied to the damaged entity

            [JsonProperty(PropertyName = "effect_name", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Effect_name { get; set; }  // Name of the status ailment to apply to an entity attacked by this entity's melee attack
        }

        public class Minecraft_spell_effects : Attribute
        {

            //Defines what mob effects to add and remove to the entity when adding this component.
            [JsonProperty(PropertyName = "add_effects", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> add_effects { get; set; } //List of effects to add to this entity after adding this component

            [JsonProperty(PropertyName = "effect", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Effect { get; set; } // Effect to add to this entity.Includes 'duration' in seconds, 'amplifier' level, 'ambient' if it is to be considered an ambient effect, and 'visible' if the effect should be visible

            [JsonProperty(PropertyName = "remove_effects", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Remove_effects { get; set; }// {get; set;} // String  List of names of effects to be removed from this entity after adding this component
        }

        public class Minecraft_strength : Attribute
        {
            [JsonProperty(PropertyName = "max", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int Max { get; set; } // {get; set;} // Integer 	5	The maximum strength of this entity

            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int Value { get; set; } // {get; set;} // Integer  1	The initial value of the strength
        }


        public class Minecraft_ambient_sound_interval : Property
        {
            //Sets the entity's delay between playing its ambient sound.
            [JsonProperty(PropertyName = "range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] range { get; set; } // {get; set;} //	16.0	Maximum time is seconds to randomly add to the ambient sound delay time.

            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float value { get; set; } // {get; set;} //   8.0	Minimum time in seconds before the entity plays its ambient sound again
        }

        public class Minecraft_collision_box : Property
        {
            //Sets the width and height of the Entity's collision box.
            [JsonProperty(PropertyName = "height", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Height { get; set; }// {get; set;} //	1.0	Height of the Collision Box in Blocks

            [JsonProperty(PropertyName = "width", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Width { get; set; } // {get; set;} // 1.0	Width and Depth of the Collision Box in Blocks
        }

        public class Minecraft_color : Property
        {
            //Defines the entity's color. Only works on vanilla entities that have predefined color values (sheep, llama, shulker).
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } // 	The Palette Color value of the entity
        }

        public class Minecraft_default_look_angle : Property
        {
            //Sets this entity's default head rotation angle.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	0.0f	Angle in degrees
        }

        public class Minecraft_equipment : Property
        {
            //Sets the Equipment table to use for this Entity.
            [JsonProperty(PropertyName = "table", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Table { get; set; } // The path to the equipment table, relative to the Behavior Pack's root
        }

        public class Minecraft_flying_speed : Property
        {
            //Speed in Blocks that this entity flies at.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	0.02	Flying speed in blocks per tick
        }

        public class Minecraft_foot_size : Property
        {
            //Sets the number of blocks the entity can step without jumping.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	0.5	The value of the size of the entity's step
        }

        public class Minecraft_friction_modifier : Property
        {
            //Defines how much does friction affect this entity.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	1.0	The higher the number, the more the friction affects this entity.A value of 1.0 means regular friction, while 2.0 means twice as much
        }

        public class Minecraft_ground_offset : Property
        {
            //Sets the offset from the ground that the entity is actually at.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	0.0	The value of the entity's offset from the terrain, in blocks
        }
        public class Minecraft_is_dyeable : Property
        {
            //Allows dyes to be used on this entity to change its color.
            [JsonProperty(PropertyName = "interact_text", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Interact_text { get; set; }// {get; set;} // String       The text that will display when interacting with this entity with a dye when playing with Touch-screen controls
        }


        public class Minecraft_item_controllable : Property
        {
            //Defines what items can be used to control this entity while ridden
            [JsonProperty(PropertyName = "control_items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> Control_items { get; set; } // List List of items that can be used to control this entity
        }


        public class Minecraft_loot : Property
        {
            //Sets the loot table for what items this entity drops upon death.
            [JsonProperty(PropertyName = "table", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Table { get; set; } // The path to the loot table, relative to the Behavior Pack's root
        }

        public class Minecraft_mark_variant : Property
        {
            //Additional variant value.Can be used to further differentiate variants.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } // 	The ID of the variant.By convention, 0 is the ID of the base entity
        }

        public class Minecraft_push_through : Property
        {
            //Sets the distance through which the entity can push through.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	0.0	The value of the entity's push-through, in blocks
        }

        public class Minecraft_scale : Property
        {
            //Sets the entity's visual size.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	1.0	The value of the scale. 1.0 means the entity will appear at the scale they are defined in their model. Higher numbers make the entity bigger
        }

        public class Minecraft_sound_volume : Property
        {
            //Sets the entity's base volume for sound effects.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	1.0	The value of the volume the entity uses for sound effects
        }

        public class Minecraft_type_family : Property
        {
            //Defines the families this entity belongs to.
            [JsonProperty(PropertyName = "family", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> Family { get; set; } // List        List of family names
        }


        public class Minecraft_variant : Property
        {
            //Used to differentiate the component group of a variant of an entity from others (e.g.ocelot, villager)
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } // {get; set;} // Integer  0	The ID of the variant.By convention, 0 is the ID of the base entity
        }

        public class Minecraft_walk_animation_speed : Property
        {
            //Sets the speed multiplier for this entity's walk animation speed.
            [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Value { get; set; } //	1.0	The higher the number, the faster the animation for walking plays. A value of 1.0 means normal speed, while 2.0 means twice as fast
        }


        public class Minecraft_addrider : Component
        {
            //Adds a rider to the entity.Requires public class Minecraft_rideable.
            [JsonProperty(PropertyName = "entity_pipe", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Entity_type { get; set; } //  The entity type that will be riding this entity
        }

        public class Minecraft_ageable : Component
        {
            //Adds a timer for the entity to grow up.It can be accelerated by giving the entity the items it likes as defined by feedItems.
            [JsonProperty(PropertyName = "duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Duration { get; set; } // 	1200.0	Amount of time before the entity grows

            [JsonProperty(PropertyName = "feedItems", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> FeedItems { get; set; } //  List List of items that can be fed to the entity.Includes 'item' for the item name and 'growth' to define how much time it grows up by

            [JsonProperty(PropertyName = "grow_up", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Grow_up { get; set; } // {get; set;} // String  Event to run when this entity grows up
        }

        public class Minecraft_angry : Component
        {
            //Defines the entity's 'angry' state using a timer.
            [JsonProperty(PropertyName = "broadcastAnger", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool BroadcastAnger { get; set; } // {get; set;} // Boolean	false	If true, other entities of the same entity definition within the broadcastRange will also become angry

            [JsonProperty(PropertyName = "broadcastRage", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int BroadcastRange { get; set; } // {get; set;} // Integer 	20	Distance in blocks within which other entities of the same entity definition will become angry

            [JsonProperty(PropertyName = "calm_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Calm_event { get; set; } // {get; set;} // String  Event to run after the number of seconds specified in duration expires(when the entity stops being 'angry')

            [JsonProperty(PropertyName = "duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int Duration { get; set; } // {get; set;} // Integer  25	The amount of time in seconds that the entity will be angry
        }

        public class Minecraft_boostable : Component
        {
            public class Boost_items
            {
                [JsonProperty(PropertyName = "damage", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public int damage { get; set; } // {get; set;} // Integer  1	This is the damage that the item will take each time it is used

                [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string item { get; set; } // {get; set;} // String  Name of the item that can be used to boost

                [JsonProperty(PropertyName = "replaceItem", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string replaceItem { get; set; } //  {get; set;} // String  The item used to boost will become this item once it is used up
            }

            //Defines the conditions and behavior of a rideable entity's boost
            [JsonProperty(PropertyName = "boost_items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<Boost_items> boost_items { get; set; } // List        List of items that can be used to boost while riding this entity.Each item has the following properties:

            [JsonProperty(PropertyName = "duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int Duration { get; set; } // {get; set;} // Integer 	3	Time in seconds for the boost

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Speed_multiplier { get; set; } // {get; set;} //	1.0	Factor by which the entity's normal speed increases. E.g. 2.0 means go twice as fast
        }

        public class Minecraft_breathable : Component
        {
            //Defines what blocks this entity can breathe in and gives them the ability to suffocate
            [JsonProperty(PropertyName = "breathBlocks", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> BreatheBlocks { get; set; } // List List of blocks this entity can breathe in, in addition to the above

            [JsonProperty(PropertyName = "breathesAir", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool BreathesAir { get; set; } //	true	If true, this entity can breathe in air

            [JsonProperty(PropertyName = "breathesLava", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool BreathesLava { get; set; } //	If true, this entity can breathe in lava

            [JsonProperty(PropertyName = "breathesSolids", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool BreathesSolids { get; set; } //	If true, this entity can breathe in solid blocks

            [JsonProperty(PropertyName = "breathesWater", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool BreathesWater { get; set; } //	If true, this entity can breathe in water

            [JsonProperty(PropertyName = "generatesBubbles", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool GeneratesBubbles { get; set; } //		If true, this entity will have visible bubbles while in water

            [JsonProperty(PropertyName = "nonBreatheBlocks", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> nonBreatheBlocks { get; set; } // List List of blocks this entity can't breathe in, in addition to the above

            [JsonProperty(PropertyName = "suffocateTime", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int SuffocateTime { get; set; } // {get; set;} // Integer 	-20	Time in seconds between suffocation damage

            [JsonProperty(PropertyName = "totalSupply", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int totalSupply { get; set; } // {get; set;} // Integer 	15	Time in seconds the entity can hold its breath
        }

        public class Minecraft_breedable : Component
        {
            //Defines the way an entity can get into the 'love' state.
            [JsonProperty(PropertyName = "allowSitting", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool AllowSitting { get; set; } // {get; set;} // Boolean	false	If true, entities can breed while sitting

            [JsonProperty(PropertyName = "breedCooldown", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float breedCooldown { get; set; } // {get; set;} // 60.0	Time in seconds before the Entity can breed again

            [JsonProperty(PropertyName = "breedItems", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> breedItems { get; set; } // List The list of items that can be used to get the entity into the 'love' state

            public class BreedsWithSub
            {
                [JsonProperty(PropertyName = "babyType", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string babyType { get; set; } // {get; set;} // String  The entity definition of this entity's babies

                [JsonProperty(PropertyName = "breed_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string breed_event { get; set; } // {get; set;} // String       Event to run when this entity breeds

                [JsonProperty(PropertyName = "mateType", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string mateType { get; set; } // {get; set;} // String       The entity definition of this entity's mate
            }

            [JsonProperty(PropertyName = "breedsWith", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<BreedsWithSub> breedsWith { get; set; } // List The list of entity definitions that this entity can breed with

            [JsonProperty(PropertyName = "extraBabyChance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float extraBabyChance { get; set; }// {get; set;} //	0.0	Chance that up to 16 babies will spawn between 0.0 and 1.0, where 1.0 is 100%

            [JsonProperty(PropertyName = "inheritTamed", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool inheritTamed { get; set; } // Boolean	true	If true, the babies will be automatically tamed if its parents are

            public class Mutation_factorSub
            {
                // JSON Object     Determines how likely the babies are to NOT inherit one of their parent's variances. Values are between 0.0 and 1.0, with a higher number meaning more likely to mutate
                [JsonProperty(PropertyName = "color", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float color { get; set; } // 0.0	The percentage chance of a mutation on the entity's color

                [JsonProperty(PropertyName = "extra_variant", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float extra_variant { get; set; } //	0.0	The percentage chance of a mutation on the entity's extra variant type

                [JsonProperty(PropertyName = "variant", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float variant { get; set; } //	0.0	The percentage chance of a mutation on the entity's variant type
            }

            [JsonProperty(PropertyName = "mutation_factor", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public Mutation_factorSub Mutation_factor { get; set; }

            [JsonProperty(PropertyName = "requireTame", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool requireTame { get; set; } // Boolean	true	If true, the entities need to be tamed first before they can breed.
        }

        public class Minecraft_damage_sensor : Component
        {
            //Defines what events to call when this entity is damaged by specific entities or items. Can be either an array or a single instance.
            [JsonProperty(PropertyName = "cause", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string cause { get; set; } // {get; set;} // String  Type of damage that triggers this set of events

            [JsonProperty(PropertyName = "deals_damage", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool deals_damage { get; set; } // Boolean true	If true, the damage dealt to the entity will take off health from it. Set to false to make the entity ignore that damage

            [JsonProperty(PropertyName = "on_damage", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public OnDamageFilters on_damage { get; set; } // List List of triggers with the events to call when taking this specific kind of damage. Allows specifying filters for entity definitions and events
        }

        public class Minecraft_environment_sensor : Component
        {
            //Creates a trigger based on environment conditions.
            [JsonProperty(PropertyName = "on_environment", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> on_environment { get; set; } // List        The list of triggers that fire when the environment conditions match the given filter criteria.
        }

        public class Minecraft_equippable : Component
        {
            //Defines an entity's behavior for having items equipped to it
            public class EquippableSub
            {
                [JsonProperty(PropertyName = "accepted_items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<string>))]
                List<string> accepted_items { get; set; } // List The list of items that can go in this slot

                [JsonProperty(PropertyName = "interact_text", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string interact_text { get; set; } // {get; set;} // String  Text to be displayed when the entity can be equipped with this item when playing with Touch-screen controls

                [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string item { get; set; } // {get; set;} // String       Name of the item that can be equipped for this slot

                [JsonProperty(PropertyName = "on_equip", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public MinecraftEvent on_equip { get; set; } // {get; set;} // String  Event to trigger when this entity is equipped with this item

                [JsonProperty(PropertyName = "on_unequip", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public MinecraftEvent on_unequip { get; set; } // {get; set;} // String  Event to trigger when this item is removed from this entity

                [JsonProperty(PropertyName = "slot", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public int slot { get; set; } // {get; set;} // Integer  0	The slot number of this slot
            }

            [JsonProperty(PropertyName = "slots", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EquippableSub>))]
            public List<EquippableSub> slots { get; set; } // List        List of slots and the item that can be equipped
        }

        public class Minecraft_explode : Component
        {
            //Defines how the entity explodes.
            [JsonProperty(PropertyName = "breaks_blocks", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool breaks_blocks { get; set; } // Boolean	true	If true, the explosion will destroy blocks in the explosion radius

            [JsonProperty(PropertyName = "causesFire", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool causesFire { get; set; } // Boolean false	If true, blocks in the explosion radius will be set on fire

            [JsonProperty(PropertyName = "destroyAffectedByGriefing", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool destroyAffectedByGriefing { get; set; } // Boolean	false	If true, whether the explosion breaks blocks is affected by the mob griefing game rule

            [JsonProperty(PropertyName = "fireAffectedByGriefing", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool fireAffectedByGriefing { get; set; } // Boolean false	If true, whether the explosion causes fire is affected by the mob griefing game rule

            public class FuseLength
            {
                public FuseLength(Int64 val)
                {
                    RangeMin = val;
                    RangeMax = val;
                }

                public static implicit operator FuseLength(Int64 value)
                {
                    return new FuseLength(value);
                }


                public FuseLength()
                {
                }

                [JsonProperty(PropertyName = "range_min", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float RangeMin { get; set; }

                [JsonProperty(PropertyName = "range_max", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float RangeMax { get; set; }
            }

            [JsonProperty(PropertyName = "fuseLength", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public FuseLength fuseLength { get; set; } // Range[a, b][0.0, 0.0] The range for the random amount of time the fuse will be lit before exploding. A negative value means the explosion will be immediate

            [JsonProperty(PropertyName = "fuseLit", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool fuseLit { get; set; } // Boolean false	If true, the fuse is already lit when this component is added to the entity

            [JsonProperty(PropertyName = "maxResistance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float maxResistance { get; set; } // Infinite Blocks with less resistance than this value will be broken by the explosion

            [JsonProperty(PropertyName = "power", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float power { get; set; } // 3.0	The radius of the explosion in blocks and the amount of damage the explosion deals
        }

        public class Minecraft_healable : Component
        {
            //Defines the interactions with this entity for healing it.

            public class HealableSub
            {
                [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<Filter>))]
                public List<Filter> filters { get; set; }// Minecraft Filter Conditions that make this entry in the list valid

                [JsonProperty(PropertyName = "force_use", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public bool force_use { get; set; } // Boolean false	Determines if item can be used regardless of entity being full health

                [JsonProperty(PropertyName = "heal_amount", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float heal_amount { get; set; } //	1.0	The amount of health this entity gains when fed this item

                [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string item { get; set; } //String Name of the item this entity likes and can be used to heal this entity
            }

            [JsonProperty(PropertyName = "items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<HealableSub>))]
            public List<HealableSub> items { get; set; } // List        The list of items that can be used to heal this entity
        }

        public class Minecraft_identity : Component
        {
            [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string ID { get; set; }
        }

        [JsonConverter(typeof(SingleOrArrayConverter<Component>))]
        public class Minecraft_interact : Component
        {
            //Defines interactions with this entity.
            [JsonProperty(PropertyName = "add_items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<ItemsObj>))]
            public List<ItemsObj> add_items { get; set; } // JSON Object Loot table with items to add to the player's inventory upon successful interaction

            [JsonProperty(PropertyName = "cooldown", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float cooldown { get; set; } //	0.0	Time in seconds before this entity can be interacted with again

            [JsonProperty(PropertyName = "hurt_item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int hurt_item { get; set; } //Integer	0	The amount of damage the item will take when used to interact with this entity.A value of 0 means the item won't lose durability

            [JsonProperty(PropertyName = "interact_text", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string interact_text { get; set; } // String       Text to show when the player is able to interact in this way with this entity when playing with Touch-screen controls

            [JsonProperty(PropertyName = "on_interact", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_interact { get; set; } // String       Event to fire when the interaction occurs

            [JsonProperty(PropertyName = "play_sounds", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string play_sounds { get; set; } // String  List of sounds to play when the interaction occurs

            [JsonProperty(PropertyName = "spawn_entities", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string spawn_entities { get; set; } // String       List of entities to spawn when the interaction occurs

            [JsonProperty(PropertyName = "spawn_items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<ItemsObj>))]
            public List<ItemsObj> spawn_items { get; set; }

            [JsonProperty(PropertyName = "swing", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool swing { get; set; } // Boolean	false	If true, the player will do the 'swing' animation when interacting with this entity

            [JsonProperty(PropertyName = "transform_to_item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string transform_to_item { get; set; } // String  The item used will transform to this item upon successful interaction. Format: itemName:auxValue

            [JsonProperty(PropertyName = "use_item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool use_item { get; set; } // Boolean false	If true, the interaction will use an item
        }

        public class Minecraft_inventory : Component
        {
            //Defines this entity's inventory properties.
            [JsonProperty(PropertyName = "additional_slots_per_strength", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int additional_slots_per_strength { get; set; } // Integer 	0	Number of slots that this entity can gain per extra strength

            [JsonProperty(PropertyName = "can_be_siphoned_from", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_be_siphoned_from { get; set; } // Boolean	false	If true, the contents of this inventory can be removed by a hopper

            [JsonProperty(PropertyName = "container_type", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string container_type { get; set; } // String  none    Type of container this entity has. Can be horse, minecart_chest, minecart_hopper, inventory, container or hopper

            [JsonProperty(PropertyName = "inventory_size", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int inventory_size { get; set; } // Integer  5	Number of slots the container has

            [JsonProperty(PropertyName = "linked_slots_size", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int linked_slots_size { get; set; } // Integer 	0	Number of linked slots (e.g.Player Hotbar) the container has

            [JsonProperty(PropertyName = "isprivate", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool isprivate { get; set; } // Boolean	false	If true, only the entity can access the inventory

            [JsonProperty(PropertyName = "restrict_to_owner", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool restrict_to_owner { get; set; } // Boolean	false	If true, the entity's inventory can only be accessed by its owner or itself
        }

        public class Minecraft_leashable : Component
        {
            //Allows this entity to be leashed and Defines the conditions and events for this entity when is leashed.
            [JsonProperty(PropertyName = "hard_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float hard_distance { get; set; } //	6.0	Distance in blocks at which the leash stiffens, restricting movement

            [JsonProperty(PropertyName = "max_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_distance { get; set; } //	10.0	Distance in blocks at which the leash breaks

            [JsonProperty(PropertyName = "on_leash", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_leash { get; set; } // String       Event to call when this entity is leashed

            [JsonProperty(PropertyName = "on_unleash", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_unleash { get; set; } // String  Event to call when this entity is unleashed

            [JsonProperty(PropertyName = "soft_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float soft_distance { get; set; } // 4.0	Distance in blocks at which the 'spring' effect starts acting to keep this entity close to the entity that leashed it
        }

        public class Minecraft_lookat : Component
        {
            //Defines the behavior when another entity looks at this entity.
            [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string filters { get; set; } // String   player Defines the entities that can trigger this component

            [JsonProperty(PropertyName = "look_cooldown", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] look_cooldown { get; set; } // Range[a, b][0.0, 0.0] The range for the random amount of time during which the entity is 'cooling down' and won't get angered or look for a target

            [JsonProperty(PropertyName = "look_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string look_event { get; set; } // String       Event to run when the entities specified in filters look at this entity

            [JsonProperty(PropertyName = "mAllowInvulnerable", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool mAllowInvulnerable { get; set; } // Boolean false	If true, invulnerable entities (e.g.Players in creative mode) are considered valid targets

            [JsonProperty(PropertyName = "searchRadius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float searchRadius { get; set; } // 10.0	Maximum distance this entity will look for another entity looking at it

            [JsonProperty(PropertyName = "setTarget", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool setTarget { get; set; } // Boolean true	If true, this entity will set the attack target as the entity that looked at it
        }

        public class Minecraft_movement_basic : Component
        {
            //This component accents the movement of an entity.
            [JsonProperty(PropertyName = "max_turn", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_turn { get; set; } //	30.0	The maximum number in degrees the mob can turn per tick.
        }
        public class Minecraft_movement_fly : Component
        {
            //This move control causes the mob to fly.
            [JsonProperty(PropertyName = "max_turn", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_turn { get; set; } //	30.0	The maximum number in degrees the mob can turn per tick.
        }

        public class Minecraft_movement_jump : Component
        {
            //Move control that causes the mob to jump as it moves with a specified delay between jumps.
            [JsonProperty(PropertyName = "jump_delay", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] jump_delay { get; set; } // Delay after landing when using the slime move control.

            [JsonProperty(PropertyName = "max_turn", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_turn { get; set; } // 30.0	The maximum number in degrees the mob can turn per tick.
        }

        public class Minecraft_movement_skip : Component
        {
            //This move control causes the mob to hop as it moves.
            [JsonProperty(PropertyName = "max_turn", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_turn { get; set; } // 30.0	The maximum number in degrees the mob can turn per tick.
        }

        public class Minecraft_movement_sway : Component
        {
            //This move control causes the mob to sway side to side giving the impression it is swimming.
            [JsonProperty(PropertyName = "max_turn", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_turn { get; set; } //	30.0	The maximum number in degrees the mob can turn per tick.
        }

        public class Minecraft_nameable : Component
        {
            //Allows this entity to be named (e.g. using a name tag)
            [JsonProperty(PropertyName = "allowNameTagRenaming", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool allowNameTagRenaming { get; set; } // Boolean true	If true, this entity can be renamed with name tags

            [JsonProperty(PropertyName = "alwaysShow", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool alwaysShow { get; set; } // Boolean false	If true, the name will always be shown

            [JsonProperty(PropertyName = "default_trigger", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public Trigger default_trigger { get; set; } // String       Trigger to run when the entity gets named

            public class NameActionsSub
            {
                [JsonProperty(PropertyName = "name_filter", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string name_filter { get; set; } // String  List of special names that will cause the events defined in 'on_named' to fire

                [JsonProperty(PropertyName = "on_named", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public MinecraftEvent on_named { get; set; } // String       Event to be called when this entity acquires the name specified in 'name_filter'
            }

            [JsonProperty(PropertyName = "name_actions", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<NameActionsSub>))]
            public List<NameActionsSub> name_actions { get; set; } // JSON Object Describes the special names for this entity and the events to call when the entity acquires those names
        }

        public class Minecraft_navigation_climb : Component
        {
            //Allows this entity to generate paths that include vertical walls like the vanilla Spiders do.
            [JsonProperty(PropertyName = "avoid_portals", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_portals { get; set; } // Boolean	false	Tells the pathfinder to avoid portals (like nether portals) when finding a path

            [JsonProperty(PropertyName = "avoid_sun", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_sun { get; set; } // Boolean	false	Whether or not the pathfinder should avoid tiles that are exposed to the sun when creating paths

            [JsonProperty(PropertyName = "avoid_water", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_water { get; set; } // Boolean	false	Tells the pathfinder to avoid water when creating a path

            [JsonProperty(PropertyName = "can_float", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_float { get; set; } // Boolean	false	Tells the pathfinder whether or not it can float in water

            [JsonProperty(PropertyName = "can_open_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_open_doors { get; set; } // Boolean	false	Tells the pathfinder that it can path through a closed door assuming the AI will open the door

            [JsonProperty(PropertyName = "can_pass_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_pass_doors { get; set; } // Boolean	true	Whether a path can be created through a door
        }

        public class Minecraft_navigation_float : Component
        {
            //Allows this entity to generate paths by flying around the air like the regular Ghast.
            [JsonProperty(PropertyName = "avoid_portals", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_portals { get; set; } // Boolean	false	Tells the pathfinder to avoid portals (like nether portals) when finding a path

            [JsonProperty(PropertyName = "avoid_sun", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_sun { get; set; } // Boolean	false	Whether or not the pathfinder should avoid tiles that are exposed to the sun when creating paths

            [JsonProperty(PropertyName = "avoid_water", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_water { get; set; } // Boolean	false	Tells the pathfinder to avoid water when creating a path

            [JsonProperty(PropertyName = "can_float", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_float { get; set; } // Boolean	false	Tells the pathfinder whether or not it can float in water

            [JsonProperty(PropertyName = "can_open_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_open_doors { get; set; } // Boolean	false	Tells the pathfinder that it can path through a closed door assuming the AI will open the door

            [JsonProperty(PropertyName = "can_pass_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_pass_doors { get; set; } // Boolean	true	Whether a path can be created through a door
        }

        public class Minecraft_navigation_fly : Component
        {
            //Allows this entity to generate paths in the air like the vanilla Parrots do.
            [JsonProperty(PropertyName = "avoid_portals", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_portals { get; set; } // Boolean	false	Tells the pathfinder to avoid portals (like nether portals) when finding a path

            [JsonProperty(PropertyName = "avoid_sun", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_sun { get; set; } // Boolean	false	Whether or not the pathfinder should avoid tiles that are exposed to the sun when creating paths

            [JsonProperty(PropertyName = "avoid_water", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_water { get; set; } // Boolean	false	Tells the pathfinder to avoid water when creating a path

            [JsonProperty(PropertyName = "can_float", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_float { get; set; } // Boolean	false	Tells the pathfinder whether or not it can float in water

            [JsonProperty(PropertyName = "can_open_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_open_doors { get; set; } // Boolean	false	Tells the pathfinder that it can path through a closed door assuming the AI will open the door

            [JsonProperty(PropertyName = "can_pass_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_pass_doors { get; set; } // Boolean	true	Whether a path can be created through a door
        }

        public class Minecraft_navigation_swim : Component
        {
            //Allows this entity to generate paths that include water.
            [JsonProperty(PropertyName = "avoid_portals", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_portals { get; set; } // Boolean	false	Tells the pathfinder to avoid portals (like nether portals) when finding a path

            [JsonProperty(PropertyName = "avoid_sun", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_sun { get; set; } // Boolean	false	Whether or not the pathfinder should avoid tiles that are exposed to the sun when creating paths

            [JsonProperty(PropertyName = "avoid_water", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_water { get; set; } // Boolean	false	Tells the pathfinder to avoid water when creating a path

            [JsonProperty(PropertyName = "can_float", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_float { get; set; } // Boolean	false	Tells the pathfinder whether or not it can float in water

            [JsonProperty(PropertyName = "can_open_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_open_doors { get; set; } // Boolean	false	Tells the pathfinder that it can path through a closed door assuming the AI will open the door

            [JsonProperty(PropertyName = "can_pass_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_pass_doors { get; set; } // Boolean	true	Whether a path can be created through a door
        }

        public class Minecraft_navigation_walk : Component
        {
            //Allows this entity to generate paths by walking around and jumping up and down a block like regular mobs.
            [JsonProperty(PropertyName = "avoid_portals", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_portals { get; set; } // Boolean	false	Tells the pathfinder to avoid portals (like nether portals) when finding a path

            [JsonProperty(PropertyName = "avoid_sun", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_sun { get; set; } // Boolean	false	Whether or not the pathfinder should avoid tiles that are exposed to the sun when creating paths

            [JsonProperty(PropertyName = "avoid_water", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_water { get; set; } // Boolean	false	Tells the pathfinder to avoid water when creating a path

            [JsonProperty(PropertyName = "can_float", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_float { get; set; } // Boolean	false	Tells the pathfinder whether or not it can float in water

            [JsonProperty(PropertyName = "can_open_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_open_doors { get; set; } // Boolean	false	Tells the pathfinder that it can path through a closed door assuming the AI will open the door

            [JsonProperty(PropertyName = "can_pass_doors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_pass_doors { get; set; } // Boolean	true	Whether a path can be created through a door
        }

        public class Minecraft_peek : Component
        {
            //Defines the entity's 'peek' behavior, defining the events that should be called during it
            [JsonProperty(PropertyName = "on_close", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_close { get; set; } // String  Event to call when the entity is done peeking

            [JsonProperty(PropertyName = "on_open", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_open { get; set; } // String  Event to call when the entity starts peeking

            [JsonProperty(PropertyName = "on_target_open", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_target_open { get; set; } // String  Event to call when the entity's target entity starts peeking
        }

        public class Minecraft_physics : Component
        {
            [JsonProperty(PropertyName = "has_collision", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool HasCollision { get; set; }
        }

        public class Minecraft_projectile : Component
        {
            //Allows the entity to be a thrown entity.
            [JsonProperty(PropertyName = "angleoffset", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float angleoffset { get; set; } //	0.0	Determines the angle at which the projectile is thrown

            [JsonProperty(PropertyName = "catchFire", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool catchFire { get; set; } // Boolean	false	If true, the entity hit will be set on fire

            [JsonProperty(PropertyName = "critParticleOnHurt", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool critParticleOnHurt { get; set; } // Boolean false   If true, the projectile will produce additional particles when a critical hit happens

            [JsonProperty(PropertyName = "destroyOnHurt", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool destroyOnHurt { get; set; } // Boolean false   If true, this entity will be destroyed when hit

            [JsonProperty(PropertyName = "filter", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string filter { get; set; } // String       Entity Definitions defined here can't be hurt by the projectile

            [JsonProperty(PropertyName = "fireAffectedByGriefing", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool fireAffectedByGriefing { get; set; } // Boolean false   If true, whether the projectile causes fire is affected by the mob griefing game rule

            [JsonProperty(PropertyName = "gravity", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float gravity { get; set; } // 0.05    The gravity applied to this entity when thrown.The higher the value, the faster the entity falls

            [JsonProperty(PropertyName = "hitSound", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string hitSound { get; set; } // String       The sound that plays when the projectile hits something

            [JsonProperty(PropertyName = "homing", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool homing { get; set; } // Boolean false   If true, the projectile homes in to the nearest entity

            [JsonProperty(PropertyName = "inertia", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float inertia { get; set; } // 0.99    The fraction of the projectile's speed maintained every frame while traveling in air

            [JsonProperty(PropertyName = "isdangerous", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool isdangerous { get; set; } // Boolean false   If true, the projectile will be treated as dangerous to the players

            [JsonProperty(PropertyName = "knockback", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool knockback { get; set; } // Boolean true    If true, the projectile will knock back the entity it hits

            [JsonProperty(PropertyName = "liquid_inertia", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float liquid_inertia { get; set; } // 0.6 The fraction of the projectile's speed maintained every frame while traveling in water

            [JsonProperty(PropertyName = "offset", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] offset { get; set; } // Vector[a, b, c]    [0.0, 0.5, 0.0]The offset from the entity's anchor where the projectile will spawn

            [JsonProperty(PropertyName = "onFireTime", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float onFireTime { get; set; } //	5.0	Time in seconds that the entity hit will be on fire for

            [JsonProperty(PropertyName = "particle", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string particle { get; set; } // String  iconcrack Particle to use upon collision

            [JsonProperty(PropertyName = "potionEffect", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int potionEffect { get; set; } // Integer 	-1	Defines the effect the arrow will apply to the entity it hits

            [JsonProperty(PropertyName = "power", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float power { get; set; } //	1.3	Determines the velocity of the projectile

            [JsonProperty(PropertyName = "reflectOnHurt", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool reflectOnHurt { get; set; } // Boolean	false	If true, this entity will be reflected back when hit

            [JsonProperty(PropertyName = "semirandomdiffdamage", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool semirandomdiffdamage { get; set; } // Boolean	false	If true, damage will be randomized based on damage and speed

            [JsonProperty(PropertyName = "shootSound", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string shootSound { get; set; } // String  The sound that plays when the projectile is shot

            [JsonProperty(PropertyName = "shoottarget", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool shoottarget { get; set; } // Boolean	true	If true, the projectile will be shot towards the target of the entity firing it

            [JsonProperty(PropertyName = "shouldbounce", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool shouldbounce { get; set; } // Boolean	false	If true, the projectile will bounce upon hit

            [JsonProperty(PropertyName = "splashPotion", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool splashPotion { get; set; } // Boolean	false	If true, the projectile will be treated like a splash potion

            [JsonProperty(PropertyName = "splashRange", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float splashRange { get; set; } //	4.0	Radius in blocks of the 'splash' effect

            [JsonProperty(PropertyName = "uncertaintyBase", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float uncertaintyBase { get; set; } //	0.0	The base accuracy. Accuracy is determined by the formula uncertaintyBase - difficultyLevel * uncertaintyMultiplier

            [JsonProperty(PropertyName = "uncertaintyMultiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float uncertaintyMultiplier { get; set; } //	0.0	Determines how much difficulty affects accuracy. Accuracy is determined by the formula uncertaintyBase - difficultyLevel * uncertaintyMultiplier
        }

        public class Minecraft_rail_movement : Component
        {
            //Defines the entity's movement on the rails. An entity with this component is only allowed to move on the rail.
            [JsonProperty(PropertyName = "max_speed", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_speed { get; set; } //	0.4	Maximum speed that this entity will move at when on the rail
        }

        public class Minecraft_rail_sensor : Component
        {
            //Defines the behavior of the entity when the rail gets activated or deactivated.
            [JsonProperty(PropertyName = "check_block_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool check_block_types { get; set; } // Boolean	false	If true, on tick this entity will trigger its on_deactivate behavior

            [JsonProperty(PropertyName = "eject_on_activate", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool eject_on_activate { get; set; } // Boolean	true	If true, this entity will eject all of its riders when it passes over an activated rail

            [JsonProperty(PropertyName = "eject_on_deactivate", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool eject_on_deactivate { get; set; } // Boolean	false	If true, this entity will eject all of its riders when it passes over a deactivated rail

            [JsonProperty(PropertyName = "on_activate", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_activate { get; set; } // String  Event to call when the rail is activated

            [JsonProperty(PropertyName = "on_deactivate", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_deactivate { get; set; } // String  Event to call when the rail is deactivated

            [JsonProperty(PropertyName = "tick_command_block_on_activate", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool tick_command_block_on_activate { get; set; } // Boolean	true	If true, command blocks will start ticking when passing over an activated rail

            [JsonProperty(PropertyName = "tick_command_block_on_deactivate", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool tick_command_block_on_deactivate { get; set; } // Boolean	false	If false, command blocks will stop ticking when passing over a deactivated rail
        }

        public class Minecraft_rideable : Component
        {
            //Determines whether this entity can be ridden. Allows specifying the different seat positions and quantity.
            [JsonProperty(PropertyName = "controlling_seat", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int controlling_seat { get; set; } // Integer 	0	The seat that designates the driver of the entity

            [JsonProperty(PropertyName = "crouching_skip_interact", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool crouching_skip_interact { get; set; } // Boolean	true	If true, this entity can't be interacted with if the entity interacting with it is crouching

            [JsonProperty(PropertyName = "family_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> family_types { get; set; } // List List of entities that can ride this entity

            [JsonProperty(PropertyName = "interact_text", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string interact_text { get; set; } // String  The text to display when the player can interact with the entity when playing with Touch-screen controls

            [JsonProperty(PropertyName = "pull_in_entities", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool pull_in_entities { get; set; } // Boolean	false	If true, this entity will pull in entities that are in the correct family_types into any available seats

            [JsonProperty(PropertyName = "seat_count", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int seat_count { get; set; } // Integer 	1	The number of entities that can ride this entity at the same time

            public class SeatsSub
            {
                [JsonProperty(PropertyName = "lock_rider_rotation", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float lock_rider_rotation { get; set; } //	181.0	Angle in degrees that a rider is allowed to rotate while riding this entity. Omit this property for no limit

                [JsonProperty(PropertyName = "max_rider_count", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public int max_rider_count { get; set; } // Integer 	0	Defines the maximum number of riders that can be riding this entity for this seat to be valid

                [JsonProperty(PropertyName = "min_rider_count", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public int min_rider_count { get; set; } // Integer 	0	Defines the minimum number of riders that need to be riding this entity before this seat can be used

                [JsonProperty(PropertyName = "position", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float[] position { get; set; } // Position of this seat relative to this entity's position

                [JsonProperty(PropertyName = "rotate_rider_by", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float rotate_rider_by { get; set; } //	0.0	Offset to rotate riders by
            }

            [JsonProperty(PropertyName = "seats", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<SeatsSub>))]
            public List<SeatsSub> seats { get; set; } // List The list of positions and number of riders for each position for entities riding this entity
        }

        public class Minecraft_scale_by_age : Component
        {
            //Defines the entity's size interpolation based on the entity's age.
            [JsonProperty(PropertyName = "end_scale", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float end_scale { get; set; } //	1.0	Ending scale of the entity when it's fully grown

            [JsonProperty(PropertyName = "start_scale", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float start_scale { get; set; } //	1.0	Initial scale of the newborn entity
        }

        public class Minecraft_shareables : Component
        {
            //Defines a list of items the mob wants to share. Each item must have the following parameters:
            [JsonProperty(PropertyName = "craft_into", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string craft_into { get; set; } // String  Defines the item this entity wants to craft with the item defined above. Should be an item name

            [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string item { get; set; } // String  The name of the item

            [JsonProperty(PropertyName = "surplus_amount", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int surplus_amount { get; set; } // Integer 	-1	Number of this item considered extra that the entity wants to share

            [JsonProperty(PropertyName = "want_amount", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int want_amount { get; set; } // Integer 	-1	Number of this item this entity wants to share
        }

        public class Minecraft_shooter : Component
        {
            //Defines the entity's ranged attack behavior.
            [JsonProperty(PropertyName = "auxVal", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int auxVal { get; set; } // Integer 	-1	ID of the Potion effect to be applied on hit

            [JsonProperty(PropertyName = "def", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string def { get; set; } // String  Entity definition to use as projectile for the ranged attack. The entity definition must have the projectile component to be able to be shot as a projectile
        }

        public class Minecraft_sittable : Component
        {
            //Defines the entity's 'sit' state.
            [JsonProperty(PropertyName = "sit_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string sit_event { get; set; } // String  Event to run when the entity enters the 'sit' state

            [JsonProperty(PropertyName = "stand_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string stand_event { get; set; } // String  Event to run when the entity exits the 'sit' state
        }

        public class Minecraft_spawn_entity : Component
        {
            //Adds a timer after which this entity will spawn another entity or item (similar to vanilla's chicken's egg-laying behavior).
            [JsonProperty(PropertyName = "max_wait_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int max_wait_time { get; set; } // Integer 	600	Maximum amount of time to randomly wait in seconds before another entity is spawned

            [JsonProperty(PropertyName = "min_wait_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int min_wait_time { get; set; } // Integer 	300	Minimum amount of time to randomly wait in seconds before another entity is spawned

            [JsonProperty(PropertyName = "spawn_entity", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string spawn_entity { get; set; } // String  Identifier of the entity to spawn. Leave empty to spawn the item defined above instead

            [JsonProperty(PropertyName = "spawn_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string spawn_event { get; set; } // String  public class Minecraft_entity_born Event to call when the entity is spawned

            [JsonProperty(PropertyName = "spawn_item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string spawn_item { get; set; } // String  egg Name of the item to spawn

            [JsonProperty(PropertyName = "spawn_method", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string spawn_method { get; set; } // String  born Method to use to spawn the entity

            [JsonProperty(PropertyName = "spawn_sound", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string spawn_sound { get; set; } // String  plop Name of the sound effect to play when the entity is spawned
        }

        public class Minecraft_tameable : Component
        {
            //Defines the rules for a mob to be tamed by the player.
            [JsonProperty(PropertyName = "probability", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float probability { get; set; } //	1.0	The chance of taming the entity with each item use between 0.0 and 1.0, where 1.0 is 100%

            [JsonProperty(PropertyName = "tameItems", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> tameItems { get; set; }// List The list of items that can be used to tame this entity

            [JsonProperty(PropertyName = "tame_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string tame_event { get; set; } // String  Event to run when this entity becomes tamed
        }

        public class Minecraft_tamemount : Component
        {
            //Allows the Entity to be tamed by mounting it.
            [JsonProperty(PropertyName = "attemptTemperMod", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int attemptTemperMod { get; set; } // Integer 	5	The amount the entity's temper will increase when mounted

            public class AutoRejectSub
            {
                [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<string>))]
                public List<string> item { get; set; } // String  Name of the item this entity dislikes and will cause it to get angry if used while untamed
            }

            [JsonProperty(PropertyName = "autoRejectItems", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public AutoRejectSub autoRejectItems { get; set; } // JSON Object The list of items that, if carried while interacting with the entity, will anger it

            public class FeedItemsSub
            {
                [JsonProperty(PropertyName = "item", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<string>))]
                public List<string> item { get; set; } // String  Name of the item this entity likes and can be used to increase this entity's temper

            }

            [JsonProperty(PropertyName = "feedItems", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<FeedItemsSub>))]
            public List<FeedItemsSub> feedItems { get; set; }// JSON Object The list of items that can be used to increase the entity's temper and speed up the taming process

            [JsonProperty(PropertyName = "temperMod", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float temperMod { get; set; } // 0.0 The amount of temper this entity gains when fed this item

            [JsonProperty(PropertyName = "feed_text", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string feed_text { get; set; } // String  The text that shows in the feeding interact button

            [JsonProperty(PropertyName = "maxTemper", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int maxTemper { get; set; } // Integer  100 The maximum value for the entity's random starting temper

            [JsonProperty(PropertyName = "minTemper", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string minTemper { get; set; } // Integer  0   The minimum value for the entity's random starting temper

            [JsonProperty(PropertyName = "ride_text", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string ride_text { get; set; } // String       The text that shows in the riding interact button

            [JsonProperty(PropertyName = "tame_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string tame_event { get; set; } // String       Event that triggers when the entity becomes tamed
        }

        public class Minecraft_target_nearby_sensor : Component
        {
            //Defines the entity's range within which it can see or sense other entities to target them.
            [JsonProperty(PropertyName = "inside_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float inside_range { get; set; } // 1.0 Maximum distance in blocks that another entity will be considered in the 'inside' range

            [JsonProperty(PropertyName = "on_inside_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_inside_range { get; set; } // String       Event to call when an entity gets in the inside range.Can specify 'event' for the name of the event and 'target' for the target of the event

            [JsonProperty(PropertyName = "on_outside_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent on_outside_range { get; set; } // String       Event to call when an entity gets in the outside range.Can specify 'event' for the name of the event and 'target' for the target of the event

            [JsonProperty(PropertyName = "outside_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float outside_range { get; set; } // 5.0 Maximum distance in blocks that another entity will be considered in the 'outside' range
        }

        public class Minecraft_teleport : Component
        {
            //Defines an entity's teleporting behavior.
            [JsonProperty(PropertyName = "darkTeleportChance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float darkTeleportChance { get; set; } // 0.01    Modifies the chance that the entity will teleport if the entity is in darkness

            [JsonProperty(PropertyName = "lightTeleportChance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float lightTeleportChance { get; set; } // 0.01    Modifies the chance that the entity will teleport if the entity is in daylight

            [JsonProperty(PropertyName = "maxRandomTeleportTime", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float maxRandomTeleportTime { get; set; } // 20.0    Maximum amount of time in seconds between random teleports

            [JsonProperty(PropertyName = "minRandomTeleportTime", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float minRandomTeleportTime { get; set; } // 0.0 Minimum amount of time in seconds between random teleports

            [JsonProperty(PropertyName = "randomTeleportCube", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] randomTeleportCube { get; set; } // Entity will teleport to a random position within the area defined by this cube

            [JsonProperty(PropertyName = "randomTeleports", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool randomTeleports { get; set; } // Boolean	true	If true, the entity will teleport randomly

            [JsonProperty(PropertyName = "targetDistance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float targetDistance { get; set; } //	16.0	Maximum distance the entity will teleport when chasing a target

            [JsonProperty(PropertyName = "target_teleport_chance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float target_teleport_chance { get; set; } //	1.0	The chance that the entity will teleport between 0.0 and 1.0. 1.0 means 100%
        }

        public class Minecraft_tick_world : Component
        {
            //Defines if the entity ticks the world and the radius around it to tick.
            [JsonProperty(PropertyName = "distance_to_players", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float distance_to_players { get; set; } //	128	The distance at which the closest player has to be before this entity despawns. This option will be ignored if never_despawn is true. Min: 128 blocks.

            [JsonProperty(PropertyName = "never_despawn", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool never_despawn { get; set; } // Boolean	true	If true, this entity will not despawn even if players are far away. If false, distance_to_players will be used to determine when to despawn.

            [JsonProperty(PropertyName = "radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int radius { get; set; } // Integer 	2	The area around the entity to tick. Default: 2. Allowed range: 2-6.
        }

        public class Minecraft_timer : Component
        {
            //Adds a timer after which an event will fire.
            [JsonProperty(PropertyName = "looping", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool looping { get; set; } // Boolean	true	If true, the timer will restart every time after it fires

            [JsonProperty(PropertyName = "randomInterval", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool randomInterval { get; set; } // Boolean	true	If true, the amount of time on the timer will be random between the min and max values specified in time

            [JsonProperty(PropertyName = "time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] time { get; set; } // Amount of time in seconds for the timer. Can be specified as a number or a pair of numbers (min and max)

            [JsonProperty(PropertyName = "time_down_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public MinecraftEvent time_down_event { get; set; } // String  Event to fire when the time on the timer runs out
        }

        public class Minecraft_trade_table : Component
        {
            //Defines this entity's ability to trade with players.
            [JsonProperty(PropertyName = "display_name", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string display_name { get; set; } // String  Name to be displayed while trading with this entity

            [JsonProperty(PropertyName = "table", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string table { get; set; } // String  File path relative to the resource pack root for this entity's trades
        }

        public class Minecraft_transformation : Component
        {
            //Defines an entity's transformation from the current definition into another

            public class AddSub
            {
                [JsonProperty(PropertyName = "component_groups", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<string>))]
                public List<string> component_groups { get; set; } // List        Names of component groups to add

            }

            [JsonProperty(PropertyName = "add", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public AddSub add { get; set; } // JSON Object     List of components to add to the entity after the transformation

            [JsonProperty(PropertyName = "begin_transform_sound", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string begin_transform_sound { get; set; } // String       Sound to play when the transformation starts

            public class DelaySub
            {
                [JsonProperty(PropertyName = "block_assist_chance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float block_assist_chance { get; set; } // 0.0 Chance that the entity will look for nearby blocks that can speed up the transformation.Value must be between 0.0 and 1.0

                [JsonProperty(PropertyName = "block_chance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float block_chance { get; set; } // 0.0 Chance that, once a block is found, will help speed up the transformation

                [JsonProperty(PropertyName = "block_max", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public int block_max { get; set; } // Integer  0   Maximum number of blocks the entity will look for to aid in the transformation.If not defined or set to 0, it will be set to the block radius

                [JsonProperty(PropertyName = "block_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public int block_radius { get; set; } // Integer  0   Distance in Blocks that the entity will search for blocks that can help the transformation

                [JsonProperty(PropertyName = "block_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<string>))]
                List<string> block_types { get; set; } // List        List of blocks that can help the transformation of this entity

                [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float value { get; set; } // 0.0 Time in seconds before the entity transforms
            }

            [JsonProperty(PropertyName = "delay", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public DelaySub delay { get; set; } // JSON Object Defines the properties of the delay for the transformation

            [JsonProperty(PropertyName = "into", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string into { get; set; } // String       Entity Definition that this entity will transform into

            [JsonProperty(PropertyName = "transformation_sound", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string transformation_sound { get; set; } // String       Sound to play when the entity is done transforming
        }

        public class Behavior : Component
        {
            [JsonProperty(PropertyName = "priority", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int Priority { get; set; }
        }

        public class Minecraft_behavior_avoid_mob_type : Behavior
        {
            //Allows this entity to avoid certain mob types.
            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public EntityTypes[] entity_types { get; set; } //JSON Object List of entity types this mob avoids.

            [JsonProperty(PropertyName = "max_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_dist { get; set; } // 0.0 Maximum distance to look for an entity

            [JsonProperty(PropertyName = "probability_per_strength", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float probability_per_strength { get; set; } // 1.0 Determines how likely it is that this entity will stop avoiding another entity based on that entity's strength

            [JsonProperty(PropertyName = "sprint_speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float sprint_speed_multiplier { get; set; } // 1.0 Multiplier for running speed. 1.0 means keep the regular speed, while higher numbers make the running speed faster

            [JsonProperty(PropertyName = "walk_speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float walk_speed_multiplier { get; set; } // 1.0 Multiplier for walking speed. 1.0 means keep the regular speed, while higher numbers make the walking speed faster
        }

        public class Minecraft_behavior_beg : Behavior
        {
            //Allows this mob to look at and follow the player that holds food they like.
            [JsonProperty(PropertyName = "items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> items { get; set; } // List        List of items that this mob likes

            [JsonProperty(PropertyName = "look_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float look_distance { get; set; } // 8.0 Distance in blocks the mob will beg from

            [JsonProperty(PropertyName = "look_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] look_time { get; set; } // Range[a, b]    [2, 4] The range of time in seconds this mob will stare at the player holding a food they like, begging for it
        }

        public class Minecraft_behavior_break_door : Behavior
        {
            //Allows this mob to break doors.
        }

        public class Minecraft_behavior_breed : Behavior
        {
            //Allows this mob to breed with other mobs.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_charge_attack : Behavior
        {
            //Allows the mob to attack its target by running at it.
        }

        public class Minecraft_behavior_controlled_by_player : Behavior
        {
            //Allows the mob to be controlled by the player.
        }

        public class Minecraft_behavior_defend_village_target : Behavior
        {
            //Allows the mob to stay in the village and fight mobs hostile to the villagers.
            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public EntityTypes[] entity_types { get; set; }//JSON Object List of entity types this mob considers a threat to the village
        }


        public class Minecraft_behavior_door_interact : Behavior
        {
            //Allows the mob to open and close doors.
        }

        public class Minecraft_behavior_dragonchargeplayer : Behavior
        {
            //Allows the dragon to attack a player by flying fast at them.The player is chosen by the dragonscanning goal.Can only be used by the Ender Dragon.
        }

        public class Minecraft_behavior_dragondeath : Behavior
        {
            //Allows the dragon to go out with glory. This controls the Ender Dragon's death animation and can't be used by other mobs.
        }

        public class Minecraft_behavior_dragonflaming : Behavior
        {
            //Allows the dragon to use its flame breath attack.Can only be used by the Ender Dragon.
        }

        public class Minecraft_behavior_dragonholdingpattern : Behavior
        {
            //Allows the Dragon to fly around in a circle around the center podium. Can only be used by the Ender Dragon.
        }

        public class Minecraft_behavior_dragonlanding : Behavior
        {
            //Allows the Dragon to stop flying and transition into perching mode.Can only be used by the Ender Dragon.
        }

        public class Minecraft_behavior_dragonscanning : Behavior
        {
            //Allows the dragon to look around for a player to attack while in perch mode. Can only be used by the Ender Dragon.
        }

        public class Minecraft_behavior_dragonstrafeplayer : Behavior
        {
            //Allows the dragon to fly around looking for a player and shoot fireballs at them.Can only be used by the Ender Dragon.
        }

        public class Minecraft_behavior_dragontakeoff : Behavior
        {
            //Allows the dragon to leave perch mode and go back to flying around.Can only be used by the Ender Dragon.
        }

        public class Minecraft_behavior_eat_block : Behavior
        {
            //Allows the mob to eat a block (for example, sheep eating grass).
            [JsonProperty(PropertyName = "on_eat", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public Trigger on_eat { get; set; }// Trigger Trigger to fire when the mob eats a block of grass
        }

        public class Minecraft_behavior_enderman_leave_block : Behavior
        {
            //Allows the enderman to drop a block they are carrying. Can only be used by Endermen.
        }

        public class Minecraft_behavior_enderman_take_block : Behavior
        {
            //Allows the enderman to take a block and carry it around. Can only be used by Endermen.
        }

        public class Minecraft_behavior_find_mount : Behavior
        {
            //Allows the mob to look around for another mob to ride atop it.
            [JsonProperty(PropertyName = "avoid_water", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool avoid_water { get; set; } // Boolean	false	If true, the mob will not go into water blocks when going towards a mount

            [JsonProperty(PropertyName = "mount_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float mount_distance { get; set; } //	-1.0	This is the distance the mob needs to be, in blocks, from the desired mount to mount it. If the value is below 0, the mob will use its default attack distance

            [JsonProperty(PropertyName = "start_delay", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int start_delay { get; set; } // Integer 	0	Time the mob will wait before starting to move towards the mount

            [JsonProperty(PropertyName = "target_needed", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool target_needed { get; set; } // Boolean	false	If true, the mob will only look for a mount if it has a target

            [JsonProperty(PropertyName = "within_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float within_radius { get; set; } //	0.0	Distance in blocks within which the mob will look for a mount
        }

        public class Minecraft_behavior_flee_sun : Behavior
        {
            //Allows the mob to run away from direct sunlight and seek shade.
        }

        [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

        public class Minecraft_behavior_float : Behavior
        {
            //Allows the mob to stay afloat while swimming.
        }

        public class Minecraft_behavior_float_wander : Behavior
        {
            //Allows the mob to float around like the Ghast.
            [JsonProperty(PropertyName = "float_duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] float_duration { get; set; } // Range [a, b]    [0.0, 0.0]  Range of time in seconds the mob will float around before landing and choosing to do something else

            [JsonProperty(PropertyName = "must_reach", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool must_reach { get; set; } // Boolean	false	If true, the point has to be reachable to be a valid target

            [JsonProperty(PropertyName = "random_reselect", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool random_reselect { get; set; } // Boolean false	If true, the mob will randomly pick a new point while moving to the previously selected one

            [JsonProperty(PropertyName = "xz_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int xz_dist { get; set; } // Integer  10	Distance in blocks on ground that the mob will look for a new spot to move to.Must be at least 1

            [JsonProperty(PropertyName = "y_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int y_dist { get; set; } // Integer 	7	Distance in blocks that the mob will look up or down for a new spot to move to.Must be at least 1

            [JsonProperty(PropertyName = "y_offset", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float y_offset { get; set; } //	0.0	Height in blocks to add to the selected target position
        }

        public class Minecraft_behavior_follow_caravan : Behavior
        {
            //Allows the mob to follow mobs that are in a caravan.
            [JsonProperty(PropertyName = "entity_count", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int entity_count { get; set; } // Integer 	1	Number of entities that can be in the caravan

            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; } // JSON Object List of entity types that this mob can follow in a caravan

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } // 1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_follow_mob : Behavior
        {
            //Allows the mob to follow other mobs.
            [JsonProperty(PropertyName = "search_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int search_range { get; set; } // Integer 	0	The distance in blocks it will look for a mob to follow

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

            [JsonProperty(PropertyName = "stop_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float stop_distance { get; set; } //	2.0	The distance in blocks this mob stops from the mob it is following
        }


        public class Minecraft_behavior_follow_owner : Behavior
        {
            //Allows the mob to follow the player that owns them.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

            [JsonProperty(PropertyName = "start_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float start_distance { get; set; } //	10.0	The distance in blocks that the owner can be away from this mob before it starts following it

            [JsonProperty(PropertyName = "stop_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float stop_distance { get; set; } //	2.0	The distance in blocks this mob will stop from its owner while following it
        }

        public class Minecraft_behavior_follow_parent : Behavior
        {
            //Allows the mob to follow their parent around.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_guardian_attack : Behavior
        {
            //Allows the guardian to use its laser beam attack.Can only be used by Guardians and Elder Guardians.
        }

        public class Minecraft_behavior_harvest_farm_block : Behavior
        {
            //Allows the villager to harvest nearby farms.Can only be used by Villagers.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_hurt_by_target : Behavior
        {
            //Allows the mob to target another mob that hurts them.
            [JsonProperty(PropertyName = "alert_same_type", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool alert_same_type { get; set; } // Boolean	false	If true, nearby mobs of the same type will be alerted about the damage

            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; } // JSON Object List of entity types that this mob can target when hurt by them

            [JsonProperty(PropertyName = "hurt_owner", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool hurt_owner { get; set; } // Boolean false	If true, the mob will hurt its owner and other mobs with the same owner as itself
        }

        public class Minecraft_behavior_leap_at_target : Behavior
        {
            //Allows monsters to jump at and attack their target.Can only be used by hostile mobs.
            [JsonProperty(PropertyName = "must_be_on_ground", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool must_be_on_ground { get; set; } // Boolean	true	If true, the mob will only jump at its target if its on the ground. Setting it to false will allow it to jump even if its already in the air

            [JsonProperty(PropertyName = "yd", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float yd { get; set; } //	0.0	The height in blocks the mob jumps when leaping at its target
        }

        public class Minecraft_behavior_look_at_entity : Behavior
        {
            //Allows the mob to look at nearby entities.
            [JsonProperty(PropertyName = "angle_of_view_horizontal", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_horizontal { get; set; } // Integer 	360	The angle in degrees that the mob can see in the Y-axis (up-down)

            [JsonProperty(PropertyName = "angle_of_view_vertical", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_vertical { get; set; } // Integer 	360	The angle in degrees that the mob can see in the X-axis (left-right)

            [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<Filter>))]
            public List<Filter> filters { get; set; }// Minecraft Filter Conditions that make this entry in the list valid

            [JsonProperty(PropertyName = "look_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float look_distance { get; set; } //	8.0	The distance in blocks from which the entity will look at

            [JsonProperty(PropertyName = "look_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] look_time { get; set; } //    Time range to look at the entity

            [JsonProperty(PropertyName = "probability", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float probability { get; set; } //	0.02	The probability of looking at the target. A value of 1.00 is 100%
        }

        public class Minecraft_behavior_look_at_player : Behavior
        {
            //Allows the mob to look at the player when the player is nearby.
            [JsonProperty(PropertyName = "angle_of_view_horizontal", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_horizontal { get; set; } // Integer 	360	The angle in degrees that the mob can see in the Y-axis (up-down)

            [JsonProperty(PropertyName = "angle_of_view_vertical", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_vertical { get; set; } // Integer 	360	The angle in degrees that the mob can see in the X-axis (left-right)

            [JsonProperty(PropertyName = "look_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float look_distance { get; set; } //	8.0	The distance in blocks from which the entity will look at

            [JsonProperty(PropertyName = "look_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] look_time { get; set; } //Time range to look at the entity 

            [JsonProperty(PropertyName = "probability", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float probability { get; set; } //	0.02	The probability of looking at the target. A value of 1.00 is 100%
        }

        public class Minecraft_behavior_look_at_target : Behavior
        {
            //Allows the mob to look at the entity they are targetting.
            [JsonProperty(PropertyName = "angle_of_view_horizontal", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_horizontal { get; set; } // Integer 	360	The angle in degrees that the mob can see in the Y-axis (up-down)

            [JsonProperty(PropertyName = "angle_of_view_vertical", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_vertical { get; set; } // Integer 	360	The angle in degrees that the mob can see in the X-axis (left-right)

            [JsonProperty(PropertyName = "look_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float look_distance { get; set; } //	8.0	The distance in blocks from which the entity will look at

            [JsonProperty(PropertyName = "look_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] look_time { get; set; } //Time range to look at the entity

            [JsonProperty(PropertyName = "probability", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float probability { get; set; } //	0.02	The probability of looking at the target. A value of 1.00 is 100%
        }

        public class Minecraft_behavior_look_at_trading_player : Behavior
        {
            //Allows the mob to look at the player they are trading with.
            [JsonProperty(PropertyName = "angle_of_view_horizontal", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_horizontal { get; set; } // Integer 	360	The angle in degrees that the mob can see in the Y-axis (up-down)

            [JsonProperty(PropertyName = "angle_of_view_vertical", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int angle_of_view_vertical { get; set; } // Integer 	360	The angle in degrees that the mob can see in the X-axis (left-right)

            [JsonProperty(PropertyName = "look_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float look_distance { get; set; } //	8.0	The distance in blocks from which the entity will look at

            [JsonProperty(PropertyName = "look_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] look_time { get; set; } // Time range to look at the entity

            [JsonProperty(PropertyName = "probability", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float probability { get; set; } //	0.02	The probability of looking at the target. A value of 1.00 is 100%
        }

        public class Minecraft_behavior_make_love : Behavior
        {
            //Allows the villager to look for a mate to spawn other villagers with. Can only be used by Villagers.
        }

        public class Minecraft_behavior_melee_attack : Behavior
        {
            //Allows the mob to use close combat melee attacks.
            [JsonProperty(PropertyName = "attack_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string attack_types { get; set; } // String  Defines the entity types this mob will attack

            [JsonProperty(PropertyName = "random_stop_interval", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float random_stop_interval { get; set; } // Integer 	0	Defines the probability the mob will stop fighting. A value of 0 disables randomly stopping, while a value of 1 defines a 50% chance

            [JsonProperty(PropertyName = "reach_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float reach_multiplier { get; set; } //	2.0	Multiplier for how far outside its box the mob can reach its target (this can be used to simulate a mob with longer arms by making this bigger)

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

            [JsonProperty(PropertyName = "track_target", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool track_target { get; set; } // Boolean	false	If true, this mob will chase after the target as long as it's a valid target
        }

        public class Minecraft_behavior_mount_pathing : Behavior
        {
            //Allows the mob to move around on its own while mounted seeking a target to attack.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

            [JsonProperty(PropertyName = "target_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float target_dist { get; set; } //	0.0	The distance at which this mob wants to be away from its target

            [JsonProperty(PropertyName = "track_target", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool track_target { get; set; } // Boolean	false	If true, this mob will chase after the target as long as it's a valid target
        }

        public class Minecraft_behavior_move_indoors : Behavior
        {
            //Can only be used by Villagers.Allows them to seek shelter indoors.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_move_through_village : Behavior
        {
            //Can only be used by Villagers.Allows the villagers to create paths around the village.
            [JsonProperty(PropertyName = "only_at_night", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool only_at_night { get; set; } // Boolean	false	If true, the mob will only move through the village during night time

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } // 1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_move_towards_restriction : Behavior
        {
            //Allows Guardians, Iron Golems and Villagers to move within their pre-defined area that the mob should be restricted to.Other mobs don't have a restriction defined.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_move_towards_target : Behavior
        {
            //Allows mob to move towards its current target.
            [JsonProperty(PropertyName = "within_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float within_radius { get; set; } //	0.0	Defines the radius in blocks that the mob tries to be from the target. A value of 0 means it tries to occupy the same block as the target
        }

        public class Minecraft_behavior_nearest_attackable_target : Behavior
        {
            //Allows the mob to check for and pursue the nearest valid target.
            [JsonProperty(PropertyName = "attack_interval", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int attack_interval { get; set; } // Integer 	0	Time in seconds between attacks

            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; }//  JSON Object     List of entity types that this mob considers valid targets

            [JsonProperty(PropertyName = "must_reach", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool must_reach { get; set; } // Boolean false	If true, only entities that this mob can path to can be selected as targets

            [JsonProperty(PropertyName = "must_see", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool must_see { get; set; } // Boolean false	If true, only entities in this mob's viewing range can be selected as targets

            [JsonProperty(PropertyName = "must_see_forget_duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float must_see_forget_duration { get; set; } // 	3.0	Determines the amount of time in seconds that this mob will look for a target before forgetting about it and looking for a new one when the target isn't visible any more

            [JsonProperty(PropertyName = "reselect_targets", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool reselect_targets { get; set; } // Boolean false	If true, the target will change to the current closest entity whenever a different entity is closer

            [JsonProperty(PropertyName = "within_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float within_radius { get; set; } //	0.0	Distance in blocks that the target can be within to launch an attack
        }

        public class Minecraft_behavior_ocelot_sit_on_block : Behavior
        {
            //Allows to mob to be able to sit in place like the ocelot.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } // 1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_ocelotattack : Behavior
        {
            //Can only be used by the Ocelot.Allows it to perform the sneak and pounce attack.
            [JsonProperty(PropertyName = "sneak_speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float sneak_speed_multiplier { get; set; } //	1.0	Multiplier for the sneaking speed. 1.0 means the ocelot will move at the speed it normally sneaks

            [JsonProperty(PropertyName = "sprint_speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float sprint_speed_multiplier { get; set; } // 1.0	Multiplier for the running speed of this mob while using this attack

            [JsonProperty(PropertyName = "walk_speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float walk_speed_multiplier { get; set; } // 1.0	Multiplier for the walking speed while using this attack
        }

        public class Minecraft_behavior_offer_flower : Behavior
        {
            //Allows the mob to offer the player a flower like the Iron Golem does.
        }

        public class Minecraft_behavior_open_door : Behavior
        {
            //Allows the mob to open doors.Requires the mob to be able to path through doors, otherwise the mob won't even want to try opening them.
            [JsonProperty(PropertyName = "close_door_after", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool close_door_after { get; set; } // Boolean	true	If true, the mob will close the door after opening it and going through it
        }


        public class Minecraft_behavior_owner_hurt_by_target : Behavior
        {
            //Allows the mob to target another mob that hurts their owner.
            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; } // JSON Object List of entity types that this mob can target if they hurt their owner
        }

        public class Minecraft_behavior_owner_hurt_target : Behavior
        {
            //Allows the mob to target a mob that is hurt by their owner.
            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; } //  JSON Object List of entity types that this entity can target if the potential target is hurt by this mob's owner
        }

        public class Minecraft_behavior_panic : Behavior
        {
            //Allows the mob to enter the panic state, which makes it run around and away from the damage source that made it enter this state.
            [JsonProperty(PropertyName = "force", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool force { get; set; } // Boolean	false	If true, this mob will not stop panicking until it can't move anymore or the goal is removed from it

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_peek : Behavior
        {
            //Allows the mob to peek out. This is what the shulker uses to look out of its shell.
        }

        public class Minecraft_behavior_pickup_items : Behavior
        {
            //Allows the mob to pick up items on the ground.
            [JsonProperty(PropertyName = "goal_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float goal_radius { get; set; } //	0.5	Distance in blocks within the mob considers it has reached the goal. This is the "wiggle room" to stop the AI from bouncing back and forth trying to reach a specific spot

            [JsonProperty(PropertyName = "max_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float max_dist { get; set; } // 0.0	Maximum distance this mob will look for items to pick up

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

            [JsonProperty(PropertyName = "track_target", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool track_target { get; set; } // Boolean	false	If true, this mob will chase after the target as long as it's a valid target
        }

        public class Minecraft_behavior_play : Behavior
        {
            //Allows the mob to play with other baby villagers.This can only be used by Villagers.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_player_ride_tamed : Behavior
        {
            //Allows the mob to be ridden by the player after being tamed.
        }

        public class Minecraft_behavior_raid_garden : Behavior
        {
            //Allows the mob to eat crops out of farms until they are full.
            [JsonProperty(PropertyName = "blocks", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<String> blocks { get; set; } // List        Blocks that the mob is looking for to eat

            [JsonProperty(PropertyName = "eat_delay", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int eat_delay { get; set; } // Integer 	2	Time in seconds between each time it eats

            [JsonProperty(PropertyName = "full_delay", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int full_delay { get; set; } // Integer 	100	Amount of time in seconds before this mob wants to eat again

            [JsonProperty(PropertyName = "goal_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float goal_radius { get; set; } // 0.5	Distance in blocks within the mob considers it has reached the goal. This is the "wiggle room" to stop the AI from bouncing back and forth trying to reach a specific spot

            [JsonProperty(PropertyName = "max_to_eat", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int max_to_eat { get; set; } // Integer  6	Maximum number of things this entity wants to eat

            [JsonProperty(PropertyName = "search_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int search_range { get; set; } // Integer 	0	Distance in blocks the mob will look for crops to eat

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } // 1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_random_fly : Behavior
        {
            //Allows a mob to randomly fly around.
            [JsonProperty(PropertyName = "can_land_on_trees", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_land_on_trees { get; set; } // Boolean	true	If true, the mob can stop flying and land on a tree instead of the ground

            [JsonProperty(PropertyName = "xz_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int xz_dist { get; set; } // Integer 	10	Distance in blocks on ground that the mob will look for a new spot to move to.Must be at least 1

            [JsonProperty(PropertyName = "y_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int y_dist { get; set; } // Integer 	7	Distance in blocks that the mob will look up or down for a new spot to move to.Must be at least 1
        }

        public class Minecraft_behavior_random_look_around : Behavior
        {
            //Allows the mob to randomly look around.
            [JsonProperty(PropertyName = "look_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float[] look_time { get; set; } // Range [a, b]    [2, 4]  The range of time in seconds the mob will stay looking in a random direction before looking elsewhere
        }

        public class Minecraft_behavior_random_stroll : Behavior
        {
            //Allows a mob to randomly stroll around.
            [JsonProperty(PropertyName = "xz_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int xz_dist { get; set; } // Integer 	10	Distance in blocks on ground that the mob will look for a new spot to move to.Must be at least 1

            [JsonProperty(PropertyName = "y_dist", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int y_dist { get; set; } // Integer 	7	Distance in blocks that the mob will look up or down for a new spot to move to.Must be at least 1
        }

        public class Minecraft_behavior_ranged_attack : Behavior
        {
            //Allows the mob to use ranged attacks like shooting arrows.
            [JsonProperty(PropertyName = "attack_interval_max", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int attack_interval_max { get; set; } // Integer 	0	Maximum amount of time in seconds the entity will wait after an attack before launching another

            [JsonProperty(PropertyName = "attack_interval_min", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int attack_interval_min { get; set; } // Integer  0	Minimum amount of time in seconds the entity will wait after an attack before launching another

            [JsonProperty(PropertyName = "attack_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float attack_radius { get; set; } // 0.0	Maxmimum distance the target can be for this mob to fire.If the target is further away, this mob will move first before firing

            [JsonProperty(PropertyName = "burst_interval", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float burst_interval { get; set; } //	0.0	Amount of time in seconds between each individual shot when firing multiple shots per attack

            [JsonProperty(PropertyName = "burst_shots", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int burst_shots { get; set; } // Integer  1	Number of shots fired every time the mob uses a charged attack

            [JsonProperty(PropertyName = "charge_charged_trigger", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float charge_charged_trigger { get; set; } //	0.0	The minimum amount of time in ticks the mob has to charge before firing a charged attack

            [JsonProperty(PropertyName = "charge_shoot_trigger", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float charge_shoot_trigger { get; set; } // 0.0	The minimum amount of time in ticks for the mob to start charging a charged shot. Must be greater than 0 to enable burst shots

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }

        public class Minecraft_behavior_receive_love : Behavior
        {
            //Allows the villager to stop so another villager can breed with it.Can only be used by a Villager.
        }

        public class Minecraft_behavior_restrict_open_door : Behavior
        {
            //Allows the mob to stay indoors during night time.
        }


        public class Minecraft_behavior_restrict_sun : Behavior
        {
            //Allows the mob to automatically start avoiding the sun when its a clear day out.
        }

        public class Minecraft_behavior_run_around_like_crazy : Behavior
        {
            //Allows the mob to run around aimlessly.
            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal
        }


        public class Minecraft_behavior_send_event : Behavior
        {
            //Allows the mob to send an event to another mob.
            [JsonProperty(PropertyName = "cast_duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float cast_duration { get; set; } //  Total delay of the steps Time in seconds for the entire event sending process

            public class SequenceSub
            {
                [JsonProperty(PropertyName = "base_delay", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float base_delay { get; set; } //	0.0	Amount of time in seconds before starting this step

                [JsonProperty(PropertyName = "event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public MinecraftEvent Event { get; set; } // String The event to send to the entity

                [JsonProperty(PropertyName = "sound_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public MinecraftEvent sound_event { get; set; } // String  The sound event to play when this step happens
            }

            [JsonProperty(PropertyName = "sequence", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public SequenceSub sequence { get; set; } // List        List of events to send
        }

        public class Minecraft_behavior_share_items : Behavior
        {
            //Allows the mob to give items it has to others.
            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; } // JSON Object List of entities this mob will share items with
        }


        public class Minecraft_behavior_silverfish_merge_with_stone : Behavior
        {
            //Allows the mob to go into stone blocks like Silverfish do. Currently it can only be used by Silverfish.
        }


        public class Minecraft_behavior_silverfish_wake_up_friends : Behavior
        {
            //Allows the mob to alert mobs in nearby blocks to come out. Currently it can only be used by Silverfish.
        }


        public class Minecraft_behavior_skeleton_horse_trap : Behavior
        {
            //Allows Equine mobs to be Horse Traps and be triggered like them, spawning a lightning bolt and a bunch of horses when a player is nearby.Can only be used by Horses, Mules, Donkeys and Skeleton Horses.
            [JsonProperty(PropertyName = "Duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Duration { get; set; } // 	1.0	Amount of time in seconds the trap exists. After this amount of time is elapsed, the trap is removed from the world if it hasn't been activated

            [JsonProperty(PropertyName = "within_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float within_radius { get; set; } //	0.0	Distance in blocks that the player has to be within to trigger the horse trap
        }

        public class Minecraft_behavior_slime_attack : Behavior
        {
            //Can only be used by Slimes and Magma Cubes.Allows the mob to use a melee attack like the slime's.
        }

        public class Minecraft_behavior_slime_float : Behavior
        {
            //Can only be used by Slimes and Magma Cubes.Controls their ability to float in water / lava.
        }

        public class Minecraft_behavior_slime_keep_on_jumping : Behavior
        {
            //Can only be used by Slimes and Magma Cubes.Allows the mob to continuously jump around like a slime.
        }

        public class Minecraft_behavior_slime_random_direction : Behavior
        {
            //Can only be used by Slimes and Magma Cubes.Allows the mob to move in random directions like a slime.
        }

        public class Minecraft_behavior_squid_dive : Behavior
        {
            //Allows the squid to dive down in water.Can only be used by the Squid.
        }

        public class Minecraft_behavior_squid_flee : Behavior
        {
            //Allows the squid to swim away.Can only be used by the Squid.
        }

        public class Minecraft_behavior_squid_idle : Behavior
        {
            //Allows the squid to swim in place idly. Can only be used by the Squid.
        }

        public class Minecraft_behavior_squid_move_away_from_ground : Behavior
        {
            //Allows the squid to move away from ground blocks and back to water.Can only be used by the Squid.
        }

        public class Minecraft_behavior_squid_out_of_water : Behavior
        {
            //Allows the squid to stick to the ground when outside water.Can only be used by the Squid.
        }

        public class Minecraft_behavior_stay_while_sitting : Behavior
        {
            //Allows the mob to stay put while it is in a sitting state instead of doing something else.
        }


        public class Minecraft_behavior_stomp_attack : Behavior
        {
            //Allows the mob to use the polar bear's melee attack.
            [JsonProperty(PropertyName = "attack_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string attack_types { get; set; } // String       Defines the entity types this mob will attack

            [JsonProperty(PropertyName = "random_stop_interval", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public int random_stop_interval { get; set; } // Integer  0	Defines the probability the mob will stop fighting. A value of 0 disables randomly stopping, while a value of 1 defines a 50% chance

            [JsonProperty(PropertyName = "reach_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float reach_multiplier { get; set; } // 2.0	Multiplier for how far outside its box the mob can reach its target (this can be used to simulate a mob with longer arms by making this bigger)

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

            [JsonProperty(PropertyName = "track_target", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool track_target { get; set; } // Boolean	false	If true, this mob will chase after the target as long as it's a valid target
        }

        public class Minecraft_behavior_summon_entity : Behavior
        {
            //Allows the mob to attack the player by summoning other entities.
            public class SummonChoicesSub
            {
                [JsonProperty(PropertyName = "cast_duration", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float cast_duration { get; set; } // Total delay of the steps    Time in seconds the spell casting will take

                [JsonProperty(PropertyName = "cooldown_time", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float cooldown_time { get; set; } //	0.0	Time in seconds the mob has to wait before using the spell again

                [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<Filter>))]
                public List<Filter> filters { get; set; }// Minecraft Filter Conditions that make this entry in the list valid

                [JsonProperty(PropertyName = "max_activation_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float max_activation_range { get; set; } //	-1.0	Upper bound of the activation distance in blocks for this spell

                [JsonProperty(PropertyName = "min_activation_range", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float min_activation_range { get; set; } // 1.0	Lower bound of the activation distance in blocks for this spell

                [JsonProperty(PropertyName = "particle_color", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public int particle_color { get; set; } // Integer  0	The color of the particles for this spell

                public class SequenceSub
                {
                    [JsonProperty(PropertyName = "base_delay", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public float base_delay { get; set; } // 0.0	Amount of time in seconds to wait before this step starts

                    [JsonProperty(PropertyName = "delay_per_summon", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public float delay_per_summon { get; set; } //	0.0	Amount of time in seconds before each entity is summoned in this step

                    [JsonProperty(PropertyName = "entity_lifespan", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public float entity_lifespan { get; set; } // -1.0	Amount of time in seconds that the spawned entity will be alive for. A value of -1.0 means it will remain alive for as long as it can

                    [JsonProperty(PropertyName = "Entity_type", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public string Entity_type { get; set; } //       The entity type of the entities we will spawn in this step

                    [JsonProperty(PropertyName = "num_entities_spawned", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public int num_entities_spawned { get; set; } // Integer  1	Number of entities that will be spawned in this step

                    [JsonProperty(PropertyName = "shape", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public string shape { get; set; } // String  line    The base shape of this step.Valid values are circle and line

                    [JsonProperty(PropertyName = "size", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public float size { get; set; } //	1.0	The base size of the entity

                    [JsonProperty(PropertyName = "sound_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public string sound_event { get; set; } // String       The sound event to play for this step

                    [JsonProperty(PropertyName = "summon_cap", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public int summon_cap { get; set; } // Integer  0	Maximum number of summoned entities at any given time

                    [JsonProperty(PropertyName = "summon_cap_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public float summon_cap_radius { get; set; } // 0.0	

                    [JsonProperty(PropertyName = "target", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                    public string target { get; set; } // String   self The target of the spell. This is where the spell will start (line will start here, circle will be centered here)
                }

                [JsonProperty(PropertyName = "sequence", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<SequenceSub>))]
                public List<SequenceSub> sequence { get; set; } // List List of steps for the spell.Each step has the following parameters:

                [JsonProperty(PropertyName = "start_sound_event", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public string start_sound_event { get; set; } // String  The sound event to play when using this spell

                [JsonProperty(PropertyName = "weight", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                public float weight { get; set; } // 0.0	The weight of this spell.Controls how likely the mob is to choose this spell when casting one

                [JsonProperty(PropertyName = "summon_choices", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
                [JsonConverter(typeof(SingleOrArrayConverter<SummonChoicesSub>))]
                public List<SummonChoicesSub> summon_choices { get; set; } // List        List of spells for the mob to use to summon entities.Each spell has the following parameters:
            }
        }

        public class Minecraft_behavior_swell : Behavior
        {
            //Allows the creeper to swell up when a player is nearby.It can only be used by Creepers.
            [JsonProperty(PropertyName = "start_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float start_distance { get; set; } //	10.0	This mob starts swelling when a target is at least this many blocks away

            [JsonProperty(PropertyName = "stop_distance", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float stop_distance { get; set; } // 2.0	This mob stops swelling when a target has moved away at least this many blocks
        }
        public class Minecraft_behavior_take_flower
        {
            //Can only be used by Villagers.Allows the mob to accept flowers from Iron Golems.
        }

        public class Minecraft_behavior_tempt : Behavior
        {
            //Allows the mob to be tempted by food they like.
            [JsonProperty(PropertyName = "can_get_scared", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public bool can_get_scared { get; set; } // Boolean	false	If true, the mob can stop being tempted if the player moves too fast while close to this mob

            [JsonProperty(PropertyName = "items", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> items { get; set; } //  List List of items this mob is tempted by

            [JsonProperty(PropertyName = "speed_multiplier", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float speed_multiplier { get; set; } //	1.0	Movement speed multiplier of the mob when using this AI Goal

            [JsonProperty(PropertyName = "within_radius", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float within_radius { get; set; } //	0.0	Distance in blocks this mob can get tempted by a player holding an item they like
        }

        public class Minecraft_behavior_trade_with_player : Behavior
        {
            //Allows the player to trade with this mob.
        }

        public class Minecraft_behavior_vex_copy_owner_target : Behavior
        {
            //Allows the mob to target the same entity its owner is targeting.
            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; } //  JSON Object List of entities this mob can copy the owner from
        }

        public class Minecraft_behavior_vex_random_move : Behavior
        {
            //Allows the mob to move around randomly like the Vex.
        }

        public class Minecraft_behavior_wither_random_attack_pos_goal : Behavior
        {
            //Allows the wither to launch random attacks.Can only be used by the Wither Boss.
        }

        public class Minecraft_behavior_wither_target_highest_damage : Behavior
        {
            //Allows the wither to focus its attacks on whichever mob has dealt the most damage to it.
            [JsonProperty(PropertyName = "entity_types", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            [JsonConverter(typeof(SingleOrArrayConverter<EntityTypes>))]
            public List<EntityTypes> entity_types { get; set; } //  JSON Object List of entity types the wither takes into account to find who dealt the most damage to it
        }
    }    
}

