using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    class RollsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(MinMaxOrInt));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<MinMaxOrInt>();
            }

            return new MinMaxOrInt(token.ToObject<Int64>());
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value);
            MinMaxOrInt rolls = value as MinMaxOrInt;

            if (rolls.Value > 0)
            {
                writer.WriteValue(rolls.Value);
            }
            else
            {
                JObject o = (JObject)t;

                o.WriteTo(writer);
            }
        }
    }


    public class MinMaxOrInt
    {
        public MinMaxOrInt(Int64 val)
        {
            Value = val;
        }

        public static implicit operator MinMaxOrInt(Int64 value)
        {
            return new MinMaxOrInt(value);
        }

        public bool ShouldSerializeMin()
        {
            // Only is value is unspecified
            return Value == 0;
        }

        public bool ShouldSerializeMax()
        {
            // Only is value is unspecified
            return Value == 0;
        }


        public bool ShouldSerializeValue()
        {
            // Only is value is specified
            return Value > 0;
        }

        [JsonProperty(PropertyName = "min", NullValueHandling = NullValueHandling.Ignore)]
        public Int64 Min { get; set; }

        [JsonProperty(PropertyName = "max", NullValueHandling = NullValueHandling.Ignore)]
        public Int64 Max { get; set; }

        [JsonIgnore]
        public Int64 Value { get; set; }
    }
}
