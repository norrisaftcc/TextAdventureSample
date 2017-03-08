using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
   


    // Room class consists of Name, Description, and a list of Exit objects.
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // location - not sure if needed
        // public int Row {get; set;}
        // public int Col {get; set;}

        // exits - can I go that direction?
        public bool North { get; set; }
        public bool South { get; set; }
        public bool East { get; set; }
        public bool West { get; set; }

        // contents
        // do this later


        public Room()
        {
            // default values
            Name = "Empty room";
            Description = "Nothing of interest.";
            // initialize list of room exits 
            // (none yet lead anywhere)
            North = false;
            South = false;
            East = false;
            West = false;


        }
    } // class Room
}
