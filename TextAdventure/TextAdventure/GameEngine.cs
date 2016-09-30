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

        public bool echoMode { get; set; }

        public GameEngine()
        {
            this.Init();
        }

        private void Init()
        {
            echoMode = true;

        }

        public string doCommand(string input)
        {
            string output = "";
            if (echoMode)
            {
                output +=  ">" + input;

            }
            return output;
        }

    } // class GameEngine

} // namespace
