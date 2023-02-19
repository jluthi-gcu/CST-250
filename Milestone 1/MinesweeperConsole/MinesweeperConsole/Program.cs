using MinesweeperLibrary;

namespace MinesweeperConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(12);

            //Set difficult percentage before setting up live bombs...
            //i.e. 0.50m is %50 percent of the board's grid has live bombs.
            board.Difficulty = 0.25m;

            board.setupLiveNeighbors();


            board.calculateLiveNeighbors();

            printBoard(board);


            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }

        public static void printBoard(Board board)
        {
            string headerRow = "";
            string boarder = "";

            // Build header row and top boarder
            for (int col = 0; col < board.Size; col++)
            {
                headerRow += $"+ {col}";

                // If value less than 2 digits long, add space to the right.
                if (col < 10)
                {
                    headerRow += " ";
                }

                boarder += "+---";
            }

            // Print header row & boarder
            Console.WriteLine(headerRow + "+");
            Console.WriteLine(boarder + "+");


            // Print game board.
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    Cell cell = board.Grid[row, col];


                    // Write value with left boarder and proper spacing.
                    if (cell.Live)
                    {
                        Console.Write(": * ");
                    }
                    else
                    {
                        Console.Write(": " + cell.LiveNeighbors + " ");
                    }
                   


                }

                // End line with one more colon
                Console.WriteLine(":");

                // Write divider or bottom border if last row.
                Console.WriteLine(boarder + "+");

            }



        }

    }
}