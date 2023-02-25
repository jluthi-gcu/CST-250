using ChessBoardModel;
using System.Runtime.InteropServices;

namespace ChessBoardConsoleApp
{
    public class Program
    {
        static Board myBoard = new Board(8);

        static void Main(string[] args)
        {

            // show the empty chessboard
            printGrid(myBoard);



            List<string> chessPieces = new List<string>() { "knight", "king", "rook", "bishop", "queen" };

            // Enter a chess piece name.
            string chessPiece;
            do
            {
                Console.Out.Write("Enter a valid chess piece to place on the board ");
                chessPiece = Console.ReadLine();

            } while (!chessPieces.Contains(chessPiece.ToLower()));



            // get the location of the chess piece
            Cell myLocation = setCurrentCell();


            // calculate and mark the cells where legal moves are possible
            myBoard.MarkNextLegalMoves(myLocation, chessPiece);


            // Show the chessboard and use "." for an empty square, X for the piece location
            // and "+" for a possible legal move.
            printGrid(myBoard);

            // Wait for another return key to exit the program
            Console.ReadLine();

        }


        static public void printGrid(Board myBoard)
        {

            string boarder = "";

            // Build top boarder
            for (int col = 0; col < myBoard.Size; col++)
            {
                boarder += "+---";
            }

            boarder += "+";

            // Print top boarder
            Console.WriteLine(boarder);


            // print the board on the console. Use "X" for current location, "+" for legal move and "." for an empty square.
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Console.Write("|");

                    if (myBoard.theGrid[i, j].CurrentlyOccupied)
                    {
                        Console.Write(" X ");
                    }else if (myBoard.theGrid[i, j].LegalNextMove)
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                   

                }

                Console.WriteLine("|");
                Console.WriteLine(boarder);

            }



        
        }



        static public Cell setCurrentCell()
        {

            int currentRow = 0;
            bool invalid = false;
            do
            {
                if (invalid)
                {
                    Console.WriteLine($"Must enter a number that is >= 0 and < than {myBoard.Size}. Please try again.");
                }

                try
                {
                    Console.Out.Write("Enter your current row number ");
                    currentRow = int.Parse(Console.ReadLine());

                    invalid = (currentRow < 0 || currentRow >= myBoard.Size);


                }
                catch (Exception e)
                {
                    invalid = true;
                }



                // Keep prompting user until they enter a valid choice.
            } while (invalid);



            int currentCol = 0;
            invalid = false;
            do
            {
                if (invalid)
                {
                    Console.WriteLine($"Must enter a number that is >= 0 and < than {myBoard.Size}. Please try again.");
                }

                try
                {
                    Console.Out.Write("Enter your current column number ");
                    currentCol = int.Parse(Console.ReadLine());

                    invalid = (currentCol < 0 || currentCol >= myBoard.Size);


                }
                catch (Exception e)
                {
                    invalid = true;
                }


                // Keep prompting user until they enter a valid choice.
            } while (invalid);


       


            myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;

            return myBoard.theGrid[currentRow, currentCol];

        }



    }
}