using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class CommandGo : Command
    {
        new public bool Try(String noun)
        {
            //World w = this.Engine.World;
            //Room r = w.Rooms[w.PlayerLoc];
            //foreach (Exit ex in r.Exits)
            //{
            //    if (noun == ex.Name.ToLower())
            //    {
            //        if (ex.Destination == -1)
            //        {
            //            SayLine("You can't go that way.");
            //            return false;
            //        }
            //        else
            //        {
            //            // valid room exit -- move player to new room.
            //            w.PlayerLoc = ex.Destination;
            //            SayLine("You travel " + ex.Name + " to " + w.Rooms[w.PlayerLoc].Name + ".");
            //            return true;
            //        }
            //    }
                
            //} // foreach exit
            return true;
        } // Try()
    }
}
