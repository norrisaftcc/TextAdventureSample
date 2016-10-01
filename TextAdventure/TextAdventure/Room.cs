using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    // Exit class contains Id, Destination pairs to designate where exits lead
    // in your project you should not implement Exits this way!
    // the requirements call for an enumerated type, "Directions" instead of constants.
    public class Exit
    {
        public const int NORTH = 0;
        public const int EAST = 1;
        public const int SOUTH = 2;
        public const int WEST = 3;

        public int Id { get; set; }
        public int Destination { get; set; }
        public string Name
        {
            get
            {
                switch (this.Id)
                {
                    case NORTH:
                        return "north";
                    case EAST:
                        return "east";
                    case SOUTH:
                        return "south";
                    case WEST:
                        return "west";
                    default:
                        return "No such direction";
                }
            }
        } // Name
    } // class Exit


    // Room class consists of Name, Description, and a list of Exit objects.
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Exit> Exits { get; set; }

        public Room()
        {
            // initialize list of room exits 
            // (none yet lead anywhere)
            Exits = new List<Exit>();
            for (int i=0; i<4; i++)
            {
                Exit ex = new Exit();
                ex.Id = i;
                ex.Destination = -1;
                Exits.Add(ex);
            }

        }
    } // class Room
}
