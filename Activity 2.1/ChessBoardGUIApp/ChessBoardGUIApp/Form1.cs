using ChessBoardModel;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        static public Board myBoard = new Board(8);
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public string selectedPiece = "";

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid()
        {
            // this function will fill the panel1 control with buttons
            int buttonSize = panel1.Width / myBoard.Size;
            panel1.Height = panel1.Width;

            // nested loop. Create buttons and place them in the Panel.
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c] = new Button();

                    // make each button square
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;


                    btnGrid[r, c].Click += Grid_Button_Click; // Add the same click event to each button.
                    panel1.Controls.Add(btnGrid[r, c]); // place the button on the Panel
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c); // position it in the x,y

                    // for testing purposes. Remove later.
                    //btnGrid[r, c].Text = r.ToString() + "|" + c.ToString();

                    // the Tag attribute will hold the row and column number in a string
                    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();

                }
            }

        }

        private void Grid_Button_Click(object? sender, EventArgs e)
        {
            // get the row and column number of the button jsut clicked.
            string[] strArr = (sender as Button).Tag.ToString().Split("|");
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);

            // run a helper function to label all legal moves for this piece.
            Cell currentCell = myBoard.theGrid[r, c];
            myBoard.MarkNextLegalMoves(currentCell, selectedPiece);
            updateButtonLabels(selectedPiece);


            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].BackColor = default(Color);
                }
            }


            // set the background color of the clicked button to something different.
            (sender as Button).BackColor = Color.Cornsilk;


        }




        public void updateButtonLabels(string selectedPiece)
        {
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {

                    btnGrid[r, c].Text = "";
                    if (myBoard.theGrid[r, c].CurrentlyOccupied) btnGrid[r, c].Text = selectedPiece;
                    if (myBoard.theGrid[r, c].LegalNextMove) btnGrid[r, c].Text = "Legal";


                }

            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            selectedPiece = comboBox1.Text;
        }


    }
}