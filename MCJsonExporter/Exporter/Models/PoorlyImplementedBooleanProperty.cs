using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter
{
    public class PoorlyImplementedBooleanConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(PoorlyImplementedBooleanProperty) || objectType == typeof(System.Boolean));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<PoorlyImplementedBooleanProperty>();
            }

            return new PoorlyImplementedBooleanProperty() { Value = token.ToObject<bool>() };
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

    public class PoorlyImplementedBooleanProperty : Component
    {
        public static implicit operator PoorlyImplementedBooleanProperty(bool value)
        {
            return new PoorlyImplementedBooleanProperty() { Value = value };
        }

        [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Value { get; set; } = true; // this appears to be the default in json files because nothign is specified on properties I know to be true. 
    }
}
