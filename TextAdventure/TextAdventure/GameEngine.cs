using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class GameEngine
    {
        public string NEWLINE = "\n"; // used for formatting

        public bool EchoMode { get; set; }

        public World World { get; set; }

        public GameEngine()
        {
            this.Init();
        }

        public void Init()
        {
            EchoMode = true; // echo back last command

            // init the world
            World = new World();
            World.Init();

        }

        public string EnterCommand(string input)
        {
            string output = "";
            input = input.ToLower();
            if (EchoMode)
            {
                output +=  ">" + input + NEWLINE;

            }
            string[] commands = input.Split(null);
            string verb = commands[0];
            string noun = "";
            if (commands.Count() > 1)
            {
                noun = commands[1];
            }

            output += DoCommand(verb, noun);

            return output;
        }

        private string DoCommand(string verb, string noun)
        {
            string result = "";

            // switch based on verb
            if (verb == "look")
            {
                result = DoLook(noun);
            }
            else if (verb == "go")
            {
                result = DoGo(noun);
            }

            return result;
        }

        private string DoLook(string noun)
        {
            // look without a noun gives the description of the current room
            // with a noun, give description of the object named
            string result = "";
            if (noun == "")
            {
                // "look" - room description
                Room r = World.Rooms[World.PlayerLoc];
                result += r.Name + NEWLINE;
                result += r.Description + NEWLINE;
                // list objects
                foreach (Object o in World.Objects )
                {
                    if (o.Location == r.Id)
                    {
                        result += "There is a " + o.Name + " here." + NEWLINE;
                    }
                }
                // list exits
                result += "Exits lead:";
                foreach (Exit ex in r.Exits)
                {
                    if (ex.Destination != -1)
                    {
                        result += " " + ex.Name;
                    }
                }
                
            }
            else
            {
                // "look noun" - item description
                bool exists = false;
                foreach (Object o in World.Objects)
                {
                    if (noun == o.Name)
                    {
                        exists = true;
                        result += o.Description;
                    }
                }
                if (!exists) {
                    result += "I don't see " + noun + " here.";
                }
                
            }
            result += NEWLINE;
            return result;
        }

        private string DoGo(string noun)
        {
            string result = "";
            Room r = World.Rooms[World.PlayerLoc];
            foreach (Exit ex in r.Exits)
            {
                if (noun == ex.Name.ToLower())
                {
                    if (ex.Destination == -1)
                    {
                        result += "You can't go that way." + NEWLINE;
                        return result;
                    }
                    else
                    {
                        // valid room exit -- move player to new room.
                        World.PlayerLoc = ex.Destination;
                        result += "You travel " + ex.Name + " to " + World.Rooms[World.PlayerLoc].Name + "." + NEWLINE;

                        result += DoLook("");
                    }
                }
            }

            return result;
        }

    } // class GameEngine

} // namespace
