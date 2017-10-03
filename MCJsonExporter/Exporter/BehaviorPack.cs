using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter
{
    public class BehaviorPack
    {
        public Manifest Manifest { get; internal set; }
        public Entities Entities { get; internal set; }
        public LootTables LootTables { get; internal set; }
        public Trading Trading { get; internal set; }
    }
}
