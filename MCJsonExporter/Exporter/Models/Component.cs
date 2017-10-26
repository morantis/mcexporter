using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exporter
{
    public class ComponentHolder
    {
        [JsonProperty(PropertyName = "coll", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Component> coll { get; set; }

        [JsonProperty(PropertyName = "comp", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Component comp { get; set; }
    }

    public class Component
    {
        public static implicit operator Component(bool value)
        {
            return new PoorlyImplementedBooleanProperty() { Value = value };
        }
    }

}
