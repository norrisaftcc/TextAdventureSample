namespace TextAdventure
{
    public class World
    {
        // the World class is the overall container for the state of the game world.
        public Room[,] playGrid;

        public int PlayerRow { get; set; }
        public int PlayerColumn { get; set; }
        
        public int MaxRow { get; set; }
        public int MaxCol { get; set; }
        public World()
        {
            playGrid = new TextAdventure.Room[10,10];
            MaxRow = 10;
            MaxCol = 10;
            PlayerRow = 0; // player starting location
            PlayerColumn = 0;
        }

        public void Init()
        {
            // playGrid is empty, populate
            for (int row=0; row<10; row++)
            {
                for (int col=0; col<10; col++)
                {
                    playGrid[row, col] = new Room();
                    // Room.Row = row;
                    // Room.Col = col;

                }
            }
            // set some special rooms
            playGrid[0, 0].Name = "Starting point";
            playGrid[0, 0].Description = "Home sweet home.";

            playGrid[9, 9].Name = "Goal";
            playGrid[9, 9].Description = "Full of treasure!";
            
        }

        private void StubInit()
        {
            // populate with some simple (stub) values for testing
            // unused
        }

    }
}
