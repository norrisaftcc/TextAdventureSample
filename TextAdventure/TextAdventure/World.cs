using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class World
    {
        // the World class is the overall container for the state of the game world.

        public List<Room> Rooms { get; set; }
        public List<Object> Objects { get; set; }
        public List<Creature> Creatures { get; set; }

        public int PlayerLoc { get; }

        public World()
        {
            Rooms = new List<Room>();
            Objects = new List<Object>();
            Creatures = new List<Creature>();
            //this.Init();
        }

        public void Init()
        {
            this.StubInit();
        }

        private void StubInit()
        {
            // populate with some simple (stub) values for testing
            Room r = new Room();
            r.Name = "Entry";
            r.Description = "You are standing in the entrance.";
            Rooms.Add(r);
        }

    }
}
