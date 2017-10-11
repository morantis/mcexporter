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

        static BehaviorPack MakeSource(string basePackDir)
        {
            return Serializers.PackSerializer.Deserialize(basePackDir);
        }

        static bool MakePack(BehaviorPack pack, string projectName, string baseOutputDir)
        {
            return Serializers.PackSerializer.Serialize(pack, projectName, baseOutputDir);
        }

        static void Main(string[] args)
        {
            var pack = MakeSource(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\moba\\vanillabehaviorpack-master");
            bool success = MakePack(pack, "Moba", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\moba\\MinecraftBehaviorPacks");

            if (success)
            {
                Console.Write("Succeed");
            }
            else
            {
                Console.Write("Fail");
            }
        }
    }
}
