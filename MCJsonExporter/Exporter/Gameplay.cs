using System.Collections.Generic;

namespace Exporter
{
    public class Gameplay
    {
        public LootTable FishingJson { get; set; }
        public List<LootTable> Fishing { get; set; } = new List<LootTable>();
    }
}