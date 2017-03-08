using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class CommandLook : Command
    {

        public bool Try( String arg)
        {
            if (arg == null || arg == "")
            {
                return TryLookAtRoom();
            }
            return TryLookAtObject(arg);
        }

        private bool TryLookAtRoom()
        {
            //// "look" - room description
            //World w = Engine.World;
            //Room r = w.Rooms[w.PlayerLoc];
            //SayLine(r.Name);
            //SayLine(r.Description);
            //// list objects

            //// list exits
            //Say("Exits lead: ");
            ////foreach (Exit ex in r.Exits)
            ////{
            ////    if (ex.Destination != -1)
            ////    {
            ////        Say(ex.Name + " ");
            ////    }
            ////}
            //SayLine("");
            return true;
        }

        private bool TryLookAtObject(String noun)
        {
            //// "look noun" - item description
            //World w = Engine.World;
            //Room r = w.Rooms[w.PlayerLoc];
            //bool exists = false;
            //foreach (Object o in w.Objects)
            //{
            //    if (noun == o.Name)
            //    {
            //        exists = true;
            //        if (o.Location == w.PlayerLoc)
            //        {
            //            SayLine(o.Description + ".");
            //            return true;
            //        }
            //        else
            //        {
            //            SayLine("I don't see " + noun + " here.");
            //            return false;
            //        }
                    
            //    }
            //}
            //if (!exists)
            //{
            //    SayLine("I don't recognize the noun '" + noun + "'.");
            //    return false;
            //}

            return true;
        }

    }

}
