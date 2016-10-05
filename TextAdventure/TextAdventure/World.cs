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

        public int PlayerLoc { get; set; }

        public World()
        {
            Rooms = new List<Room>();
            Objects = new List<Object>();
            Creatures = new List<Creature>();
            //this.Init();
            PlayerLoc = 0; // player starting location
        }

        public void Init()
        {
            this.StubInit();
        }

        private void StubInit()
        {
            // populate with some simple (stub) values for testing
            Room r = new Room();
            r.Id = 0;
            r.Name = "Entry";
            r.Description = "You are standing in the entrance.";
            r.Exits[Exit.NORTH].Destination = 1;
            Rooms.Add(r);

            Room r2 = new Room();
            r2.Id = 1;
            r2.Name = "Hallway";
            r2.Description = "This is a wooden hallway.";
            r2.Exits[Exit.SOUTH].Destination = 0;
            Rooms.Add(r2);

            // add a test object
            Object o = new TextAdventure.Object();
            o.Id = 1;
            o.Name = "sword";
            o.Description = "A rusty sword";
            o.Location = 0;
            Objects.Add(o);

            Object o2 = new Object();
            o2.Id = 2;
            o2.Name = "coin";
            o2.Description = "A copper coin";
            o2.Location = 1;
            Objects.Add(o2);
        }

    }
}
