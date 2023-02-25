using System.Data;

namespace ChessBoardModel
{
    public class Board
    {
        // the board is always square. Usually 8x8
        public int Size { get; set; }

        // 2d array of the Cell objects
        public Cell[,] theGrid;


        public Board(int s)
        {
            Size = s;

            // we must initialize the array to avoid Null Exception errors.
            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }


        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
           

            // step 1 - clear all LegalMoves from previous turn.
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                    theGrid[r, c].CurrentlyOccupied = false;
                }
            }

            // Updated code to set CurrentlyOccupied property.
            currentCell.CurrentlyOccupied = true;


            // step 2 - find all legal moves and mark the square.
            switch (chessPiece.ToLower())
            {
                case "knight":

                    if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }

                    if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;

                    }

                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 2 < Size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;

                    }

                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber + 2 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }

                    if (currentCell.RowNumber + 2 < Size && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }

                    if (currentCell.RowNumber + 2 < Size && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }

                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber - 2 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }

                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 2 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }


                    break;

                case "king":

                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;

                    }

                    if (currentCell.RowNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;

                    }

                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }

                    if ( currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;

                    }

                    if (currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;

                    }

                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;

                    }

                    if (currentCell.RowNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;

                    }

                    if (currentCell.RowNumber + 1 < Size && currentCell.ColumnNumber + 1 < Size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;

                    }

                    break;

                case "rook":

                    for (int r = currentCell.RowNumber - 1; r >= 0; r--)
                    {
                        theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber + 1; r < Size; r++)
                    {
                        theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                    }

                    for (int c = currentCell.ColumnNumber - 1; c >= 0; c--)
                    {
                        theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                    }

                    for (int c = currentCell.ColumnNumber + 1; c < Size; c++)
                    {
                        theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                    }


                    break;

                case "bishop":

                    for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber - 1; r >= 0 && c >= 0; r--, c--)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber + 1; r >= 0 && c < Size; r--, c++)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber - 1; r < Size && c >= 0; r++, c--)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber + 1; r < Size && c < Size; r++, c++)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    break;

                case "queen":

                    // Queen is bishop & rook moves combined

                    // Rook code
                    for (int r = currentCell.RowNumber - 1; r >= 0; r--)
                    {
                        theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber + 1; r < Size; r++)
                    {
                        theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                    }

                    for (int c = currentCell.ColumnNumber - 1; c >= 0; c--)
                    {
                        theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                    }

                    for (int c = currentCell.ColumnNumber + 1; c < Size; c++)
                    {
                        theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                    }



                    // Bishop code
                    for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber - 1; r >= 0 && c >= 0; r--, c--)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber + 1; r >= 0 && c < Size; r--, c++)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber - 1; r < Size && c >= 0; r++, c--)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber + 1; r < Size && c < Size; r++, c++)
                    {
                        theGrid[r, c].LegalNextMove = true;
                    }

                    break;

                default: 
                    break;


            }


          
        }





    }
}