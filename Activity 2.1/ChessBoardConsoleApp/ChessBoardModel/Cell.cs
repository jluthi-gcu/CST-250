namespace ChessBoardModel
{
    public class Cell
    {

        // row and col are the cell's location on the grid.
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        // T/F is the chess piece on this cell?
        public bool CurrentlyOccupied { get; set; }

        // is the square a legal move for the chess piece on the board?
        public bool LegalNextMove { get; set; }

        public Cell(int r, int c)
        {
            RowNumber = r;
            ColumnNumber = c;
        }





    }
}