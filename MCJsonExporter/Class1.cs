using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MCJsonExporter
{
    public class Class1
    {

        public Class1()
        {
            MCDataStructures.Components.Minecraft_damage_sensor sensor = new MCDataStructures.Components.Minecraft_damage_sensor();
            sensor.cause = "TheCause";
            sensor.deals_damage = true;
            sensor.on_damage = new List<string>();

            string output = JsonConvert.SerializeObject(sensor);

            if (output.Contains("foo"))
            {
                output = "";
            }

        }
        
    }


}
