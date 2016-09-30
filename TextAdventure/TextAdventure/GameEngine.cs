using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class GameEngine
    {
        public string NEWLINE = "\r\n"; // used for formatting

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

            return result;
        }

        private string DoLook(string noun)
        {
            // look without a noun gives the description of the current room
            // with a noun, give description of the object named
            string result = "";
            if (noun == "")
            {
                Room r = World.Rooms[World.PlayerLoc];
                result += r.Name + NEWLINE;
                result += r.Description += NEWLINE;
            }
            else
            {
                result += "I don't see " + noun + " here.";
            }
            return result;
        }

    } // class GameEngine

} // namespace
