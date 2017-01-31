using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnockOutSelectors.Models
{
    public class WorldList
    {
        public List<World> Worlds { get; set; }

        public WorldList()
        {
            Worlds = new List<World>();
        }

    }
    public class World
    {
        string continent { get; set; }
        string country { get; set; }
        string city { get; set; }
    }
    
}
