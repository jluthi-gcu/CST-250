namespace MinesweeperLibrary
{
    public class Cell
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public bool Live { get; set; }

        public int LiveNeighbors { get; set; }


        public Cell()
        {
            Row = -1;
            Column = -1;
            Live = false;
            LiveNeighbors = 0;
        }


      

    }
}