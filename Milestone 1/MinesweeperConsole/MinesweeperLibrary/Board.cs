using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperLibrary
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] Grid { get; set; }

        public decimal Difficulty { get; set; }


        public Board(int size)
        {
            this.Size = size;

            Grid = new Cell[size, size];

            // Initialize grid with cell instances.
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Grid[row, col] = new Cell() { Row = row, Column = col };
                }

            }


        }




        public void setupLiveNeighbors()
        {
            Random rand = new Random();

            // Calculate number of bombs to place from Size of board and difficulty percentage.

            int bombsToPlace = (int)(((Size * Size) * Difficulty));

            // Keeps track of bombs already placed.
            int bombsPlaced = 0;


            int randomRow;
            int randomCol;

            // Places bombs at random.
            while (bombsPlaced < bombsToPlace)
            {
                do
                {
                    randomRow = rand.Next(Size);
                    randomCol = rand.Next(Size);

                    // If not already a live cell then set to live, increment bombs placed, & break out of loop
                    // else try again for a differnt random cell.
                    if (Grid[randomRow, randomCol].Live == false)
                    {
                        Grid[randomRow, randomCol].Live = true;
                        bombsPlaced++;
                        break;
                    }

                } while (true);


            }


        }

        public void calculateLiveNeighbors()
        {
            // Loop through each cell.
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    // Only calculate for non live cells.
                    if (Grid[row, col].Live == false)
                    {

                        int checkRowStart = row - 1;
                        int checkRowEnd = row + 1;
                        int checkColStart = col - 1;
                        int checkColEnd = col + 1;

                        // Don't calculate edge case
                        if (row - 1 == -1)
                        {
                            checkRowStart += 1;
                        }

                        // Don't calculate edge case
                        if (row + 1 == Size)
                        {
                            checkRowEnd -= 1;
                        }

                        // Don't calculate edge case
                        if (col - 1 == -1)
                        {
                            checkColStart += 1;
                        }

                        // Don't calculate edge case
                        if (col + 1 == Size)
                        {
                            checkColEnd -= 1;
                        }

                        // Check current cells neighbors for live bombs.
                        for (int checkRow = checkRowStart; checkRow <= checkRowEnd; checkRow++)
                        {

                            for (int checkCol = checkColStart; checkCol <= checkColEnd; checkCol++)
                            {
                                // If neighbor live bomb, update current cell's LiveNeighbor count.
                                if (Grid[checkRow, checkCol].Live)
                                {
                                    Grid[row, col].LiveNeighbors += 1;

                                }


                            }

                        }

                        


                    }

                }

            }



        }

    }
}
