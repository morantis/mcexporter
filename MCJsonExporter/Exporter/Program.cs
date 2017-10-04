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
        static void Main(string[] args)
        {
            var unpacker = Unpacker.Create("C:\\Users\\pmeade\\Documents\\moba\\vanillabehaviorpack-master");
            var pack = unpacker.Extract();
            var packer = Packer.Create("Moba", pack);
            packer.Pack("C:\\Users\\pmeade\\Documents\\moba\\MinecraftBehaviorPacks"); 

            string output = JsonConvert.SerializeObject(pack);

            Console.Write(output);

        }
    }
}
