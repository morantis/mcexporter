using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exporter
{
    public class Packer
    {
        public BehaviorPack BehaviorPack { get; set; }
        public string ProjectName { get; set; }

        public static Packer Create(string projectName, BehaviorPack behaviorPack)
        {
            return new Packer() { ProjectName = projectName, BehaviorPack = behaviorPack };
        }

        public bool Pack(string outputDirectory)
        {
            var now = DateTime.Now;
            string packDirectory = outputDirectory + "/" + ProjectName + "_" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + "_" + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();

            try
            {
                Directory.CreateDirectory(packDirectory);

                BehaviorPack.Manifest.Save(packDirectory);
                BehaviorPack.Entities.Save(packDirectory);
                BehaviorPack.LootTables.Save(packDirectory);
                BehaviorPack.Trading.Save(packDirectory);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unable to create behavior pack at " + packDirectory);
                Console.Write(exception.Message);
                return false;
            }

            return true;
        }
    }
}
