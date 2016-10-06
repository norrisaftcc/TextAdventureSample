using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Command
    {
        // base Command class
        // A command has a name and a list of synonyms.
        // A command can be tried. (It may succeed, or fail.)
        //
        // Commands report their output back to the GameEngine via say(),
        // which appends to a report string

        public GameEngine Engine { get; set; }
        public string Output { get; set; }

        public Command()
        {
            this.Output = "";
        }

        public Command(GameEngine eng)
        {
            this.Engine = eng;
            this.Output = "";
        }

        public bool Try(String arg)
        {
            // typically a command will have only one arg, the noun.
            // some commands may possess more.
            SayLine("You can't do that.");
            return false;
        }

        protected void Say(String msg)
        {
            this.Output += msg;
        }

        protected void SayLine(String msg)
        {
            this.Output += msg + Engine.NEWLINE;
        }
    }
}
