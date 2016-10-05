using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Object
    {
        // base class for game objects.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Location { get; set; }
    }
}
