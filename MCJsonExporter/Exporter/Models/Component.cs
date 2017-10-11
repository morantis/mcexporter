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
        public static implicit operator Component(bool value)
        {
            return new PoorlyImplementedBooleanProperty() { Value = value };
        }
    }

}
