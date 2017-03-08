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

        private bool verbose = true;

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
                output += ">" + input + NEWLINE;

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
            if (verb == "look" || verb == "examine")
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
            // right now, only 'look'
            string result = "";
            // what room are we in?
            int row = World.PlayerRow;
            int col = World.PlayerColumn;
            // describe it to the player
            string roomName = World.playGrid[row, col].Name;
            string roomDesc = World.playGrid[row, col].Description;
            result += roomName 
                + " (" + row + "," + col + ")"
                + NEWLINE + roomDesc + NEWLINE;

            return result;
        }

        private string DoGo(string noun)
        {
            string result = "";
            int row = World.PlayerRow;
            int col = World.PlayerColumn;

            switch (noun)
            {
                case "north":
                    row--;
                    break;
                case "south":
                    row++;
                    break;
                case "west":
                    col--;
                    break;
                case "east":
                    col++;
                    break;  
            }
            // sanity check we didn't fall off the world
            string goError = "No exit" + NEWLINE;
            if (col<0)
            {
                col = 0;
                result += goError;
            }
            if (row<0)
            {
                row = 0;
                result += goError;
            }
            if (col>World.MaxCol-1)
            {
                col = World.MaxCol - 1;
                result += goError;
            }
            if (row>World.MaxRow-1)
            {
                row = World.MaxRow - 1;
                result += goError;
            }
            World.PlayerRow = row;
            World.PlayerColumn = col;

            if (verbose)
            {
                result += DoLook(""); // describe newly entered room
            }
            
            return result;

        }

    } // class GameEngine

} // namespace
