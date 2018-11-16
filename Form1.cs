/*Gavin Rodgers and Louis Rodriguez
 * 3309 Battleship project III
 * This is the Form class that handles all information that the user sees in the form
 * Last Edited: 11/7/18
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Battleship.Classes;

namespace Battleship
{
    public partial class frmBattleShip : Form
    {
        //attributes needed in form class
        private List<Player> playersList = new List<Player>(2);
        private const int maxRows = 14;
        private const int maxCols = 14;
        //internboard instantiations
        private InternalBoard PlayerABoard = new InternalBoard(maxRows);
        private InternalBoard PlayerBBoard = new InternalBoard(maxRows);
        //ship instantiation
        Ship CarrierA = new Ship("Carrier", 5);
        Ship BattleshipA = new Ship("Battleship", 4);
        Ship CruiserA = new Ship("Cruiser", 3);
        Ship SubmarineA = new Ship("Submarine", 3);
        Ship DestroyerA = new Ship("Destroyer", 2);
        Ship CarrierB = new Ship("Carrier", 5);
        Ship BattleshipB = new Ship("Battleship", 4);
        Ship CruiserB = new Ship("Cruiser", 3);
        Ship SubmarineB = new Ship("Submarine", 3);
        Ship DestroyerB = new Ship("Destroyer", 2);
        //array initialization for each board
        private Button[,] newButtonA = new Button[maxRows, maxCols];
        private Button[,] newButtonB = new Button[maxRows, maxCols];
        //initializes form
        public frmBattleShip()
        {
            InitializeComponent();
        }
        //handles the lets play button
        private void btnLetsplay_Click(object sender, EventArgs e)
        {
            resetboards();
            txtCurrentPlayer.Visible = true;
            btnLetsplay.Enabled = false;
            lblCurrentPlayer.Visible = true;
            txtCurrentPlayer.Text = txtPlayerA.Text;
            pnlKey.Visible = true;
            pnlPlayerB.Visible = true;
            btnCompletedTurn.Visible = true;
            btnCompletedTurn.Enabled = false;
            btnExit.Visible = true;
        }
        //hit or miss event handler for Board A
        private void Button_ClickA(object sender, EventArgs e)
        {
            btnCompletedTurn.Enabled = true;
            if (txtCurrentPlayer.Text == txtPlayerB.Text)
            {
                Button currentA = (sender as Button);
                if (PlayerABoard.isHit(currentA.Location.Y, currentA.Location.X) == true)
                {
                    ((Button)sender).BackColor = Color.Red;
                    ((Button)sender).Enabled = false;
                    disableBoardA();
                    PlayerABoard.decrementHitsCounter();
                }
                else
                {
                    ((Button)sender).BackColor = Color.Blue;
                    ((Button)sender).Enabled = false;
                    disableBoardA();
                }
            }
        }
        //hit or miss event handler for Board B
        private void Button_ClickB(object sender, EventArgs e)
        {
            btnCompletedTurn.Enabled = true;
            if (txtCurrentPlayer.Text == txtPlayerA.Text)
            {
                Button currentB = (sender as Button);
                if (PlayerBBoard.isHit(currentB.Location.Y, currentB.Location.X) == true)
                {
                    ((Button)sender).BackColor = Color.Red;
                    ((Button)sender).Enabled = false;
                    disableBoardB();
                    PlayerBBoard.decrementHitsCounter();
                }
                else
                {
                    ((Button)sender).Enabled = false;
                    ((Button)sender).BackColor = Color.Blue;
                    disableBoardB();
                }
            }
        }
        //converts chars to ints
        int convertCharToInt(Char c)
        {
            return ((int)(c) - (int)('0'));
        }  // end convertCharToInt
        //creates the gameboard for Battleship
        //creates the board for board A with buttons and their event handlers
        private void createBoardA()
        {
            Size size = new Size(35, 35);
            Point loc = new Point(0, 0);
            int topMargin = 0;
            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                loc.Y = (topMargin - 20) + row * (size.Height);
                loc.Y = row * (size.Height);
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col] = new System.Windows.Forms.Button();
                    newButtonA[row, col].Location = new Point(col * (size.Width), loc.Y);
                    newButtonA[row, col].Size = size;
                    newButtonA[row, col].Text = "";
                    newButtonA[row, col].Enabled = false;
                    newButtonA[row, col].Visible = true;
                    newButtonA[row, col].Name = "btn" + row + col;
                    newButtonA[row, col].Click += new EventHandler(Button_ClickA);
                    if (row == 0 || row == 1 || row == 12 || row == 13)
                    {
                        newButtonA[row, col].Visible = false;
                    }
                    if (col == 0 || col == 1 || col == 12 || col == 13)
                    {
                        newButtonA[row, col].Visible = false;
                    }
                    // Associates the same event handler with each of the buttons generated
                    // Add button to the form
                    pnlPlayerA.Controls.Add(newButtonA[row, col]);
                } // end for col
            } // end for row
        }
        //creates the board for board B with buttons and their event handlers
        public void createBoardB()
        {
            Size size = new Size(35, 35);
            Point loc = new Point(0, 0);
            int topMargin = 20;
            // The board is treated like a maxRows x MaxCols array
            pnlPlayerB.Visible = true;
            for (int row = 0; row < maxRows; row++)
            {
                loc.Y = (topMargin - 20) + row * (size.Height);
                loc.Y = row * (size.Height);
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonB[row, col] = new System.Windows.Forms.Button();
                    newButtonB[row, col].Location = new Point(col * (size.Width), loc.Y);
                    newButtonB[row, col].Size = size;
                    newButtonB[row, col].Text = "";
                    newButtonB[row, col].Enabled = false;
                    newButtonB[row, col].Visible = true;
                    newButtonB[row, col].Name = "btn" + row + col;
                    // Associates the same event handler with each of the buttons generated
                    newButtonB[row, col].Click += new EventHandler(Button_ClickB);
                    if (row == 0 || row == 1 || row == 12 || row == 13)
                    {
                        newButtonB[row, col].Visible = false;
                    }
                    if (col == 0 || col == 1 || col == 12 || col == 13)
                    {
                        newButtonB[row, col].Visible = false;
                    }
                    // Add button to the form
                    pnlPlayerB.Controls.Add(newButtonB[row, col]);
                } // end for col
            } // end for row    

        }
        // end createBoard
        //verifies input name and begins ship placement process for all for player A
        private void btnPlayerAGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlayerA.Text != "")
                {
                    Player PlayerA = new Player(txtPlayerA.Text);
                    createBoardA();
                    pnlBoatCreators.Visible = true;
                    lblLETTERS.Visible = true;
                    lblNumbers.Visible = true;
                    btnBCreateBoard.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter a Name", "Name Input");
                    txtPlayerA.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Name", "Input Error");
                txtPlayerA.Text = "";
                txtPlayerA.Focus();
            }
        }
        //verifies input name and begins ship placement process for all for player B
        private void btnPlayerBGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlayerB.Text != "")
                {
                    Player PlayerB = new Player(txtPlayerB.Text);
                    pnlPlayerB.Visible = true;
                    createBoardB();
                    pnlBuildShipsB.Visible = true;
                    lblLETTERSB.Visible = true;
                    lblNUMBERSB.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please Enter a Name", "Name Input");
                    txtPlayerA.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Name", "Input Error");
                txtPlayerB.Text = "";
                txtPlayerB.Focus();
            }
        }
        //Handles the exit button to close the game
        private void button186_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Enables the correct buttons of board A
        public void enableBoardA()
        {
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    if (newButtonA[row, col].BackColor == Color.Blue || newButtonA[row, col].BackColor == Color.Red || newButtonA[row, col].BackColor == Color.Purple || newButtonA[row, col].BackColor == Color.Yellow || newButtonA[row, col].BackColor == Color.Green || newButtonA[row, col].BackColor == Color.Black)
                    {
                        newButtonA[row, col].Enabled = false;
                    }
                    else
                    {
                        newButtonA[row, col].Enabled = true;
                    }
                }
            }
        }
        //Enables the correct buttons of board B
        public void enableBoardB()
        {
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    if (newButtonB[row, col].BackColor == Color.Blue || newButtonB[row, col].BackColor == Color.Red || newButtonB[row, col].BackColor == Color.Purple || newButtonB[row, col].BackColor == Color.Yellow || newButtonB[row, col].BackColor == Color.Green || newButtonB[row, col].BackColor == Color.Black)
                    {
                        newButtonB[row, col].Enabled = false;

                    }
                    else
                    {
                        newButtonB[row, col].Enabled = true;

                    }
                }
            }
        }
        //Event handler to Create Carrier of Board A
        private void btnCreateCarrierA_click(object sender, EventArgs e)
        {
            enableBoardA();
            btnACreateBoard.Enabled = false;
            btnCreateCarrierA.Enabled = false;
            MessageBox.Show("Please click five buttons horizontal or vertical", "Create Carrier");
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col].Click += new EventHandler(CreateCarrierA);
                }
            }
        }
        //button click event handler that handles creating carrier of Board A
        private void CreateCarrierA(object sender, EventArgs e)
        {

            if (CarrierA.CarrierACount() < 5 && CarrierA.CarrierACount() > 0)
            {
                boatsettingPoint2CarrierA(sender, e);
            }

            if (CarrierA.CarrierACount() == 0)
            {
                ((Button)sender).BackColor = Color.Purple;
                ((Button)sender).Enabled = false;
                btnCreateBattleshipA.Enabled = true;
                CarrierA.CarrierADecrement();
                disableBoardA();
                MessageBox.Show("Please click Create Battleship", "Carrier Complete");
            }
            if (CarrierA.CarrierACount() == 5)
            {
                ((Button)sender).BackColor = Color.Purple;
                ((Button)sender).Enabled = false;
                boatSettingPoint1A(sender, e);
                CarrierA.CarrierADecrement();
            }
        }
        //Event handler to Create Battleship of Board A
        private void btnCreateBattleshipA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click four buttons horizontal or vertical", "Create Battleship");
            enableBoardA();
            btnACreateBoard.Enabled = false;
            btnCreateCarrierA.Enabled = false;
            btnCreateBattleshipA.Enabled = false;
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col].Click += new EventHandler(CreateBattleShipA);
                }
            }
        }
        //button click event handler that handles creating battleship of Board A
        public void CreateBattleShipA(object sender, EventArgs e)
        {
            if (BattleshipA.BattleshipACount() < 4 && BattleshipA.BattleshipACount() > 0)
            {
                boatsettingPoint2BattleShipA(sender, e);
            }
            if (BattleshipA.BattleshipACount() == 0)
            {
                ((Button)sender).BackColor = Color.Yellow;
                ((Button)sender).Enabled = false;
                btnCreateCruiserA.Enabled = true;
                BattleshipA.BattleshipADecrement();
                disableBoardA();
                MessageBox.Show("Please click Create Battleship", "Cruiser Complete");
            }
            if (BattleshipA.BattleshipACount() == 4)
            {
                ((Button)sender).BackColor = Color.Yellow;
                ((Button)sender).Enabled = false;
                boatSettingPoint1A(sender, e);
                BattleshipA.BattleshipADecrement();
            }
        }
        //Event handler to Create Cruiser of Board A
        private void btnCreateCruiserA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click three buttons horizontal or vertical", "Create Cruiser");
            btnCreateCruiserA.Enabled = false;
            enableBoardA();

            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col].Click += new EventHandler(CreateCruiserA);
                }
            }
        }
        //button click event handler that handles creating cruiser of Board A
        private void CreateCruiserA(object sender, EventArgs e)
        {
            if (CruiserA.CruiserACount() < 3 && CruiserA.CruiserACount() > 0)
            {
                boatsettingPoint2CruiserA(sender, e);
            }
            if (CruiserA.CruiserACount() == 0)
            {
                ((Button)sender).BackColor = Color.Green;
                ((Button)sender).Enabled = false;
                btnCreateSubmarineA.Enabled = true;
                CruiserA.CruiserADecrement();
                disableBoardA();
                MessageBox.Show("Please click Create Submarine", "Cruiser Complete");
            }
            if (CruiserA.CruiserACount() == 3)
            {
                ((Button)sender).BackColor = Color.Green;
                ((Button)sender).Enabled = false;
                boatSettingPoint1A(sender, e);
                CruiserA.CruiserADecrement();
            }
        }
        //Event handler to Create Submarine of Board A
        private void btnCreateSubmarineA_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Please click three buttons horizontal or vertical", "Create Submarine");
            btnCreateSubmarineA.Enabled = false;
            enableBoardA();
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col].Click += new EventHandler(CreateSubmarineA);
                }
            }
        }
        //button click event handler that handles creating submarine of Board A
        private void CreateSubmarineA(object sender, EventArgs e)
        {
            if (SubmarineA.SubmarineACount() < 3 && SubmarineA.SubmarineACount() > 0)
            {
                boatsettingPoint2SubmarineA(sender, e);
            }
            if (SubmarineA.SubmarineACount() == 0)
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).Enabled = false;
                btnCreateDestroyerA.Enabled = true;
                SubmarineA.SubmarineADecrement();
                disableBoardA();
                MessageBox.Show("Please click Create Destroyer", "Submarine Complete");
            }
            if (SubmarineA.SubmarineACount() == 3)
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).Enabled = false;
                boatSettingPoint1A(sender, e);
                SubmarineA.SubmarineADecrement();
            }
        }
        //Event handler to Create Destroyer of Board A
        private void btnCreateDestroyerA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click two buttons horizontal or vertical", "Create Destroyer");
            btnCreateDestroyerA.Enabled = false;
            enableBoardA();
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col].Click += new EventHandler(CreateDestroyerA);
                }
            }
        }
        //button click event handler that handles creating destroyer of Board A
        private void CreateDestroyerA(object sender, EventArgs e)
        {
            if (DestroyerA.DestroyerACount() < 2 && DestroyerA.DestroyerACount() > 0)
            {
                boatsettingPoint2DestroyerA(sender, e);
            }
            if (DestroyerA.DestroyerACount() == 0)
            {                
                ((Button)sender).BackColor = Color.Orange;
                ((Button)sender).Enabled = false;
                btnOk1.Visible = true;
                DestroyerA.DestroyerADecrement();
                disableBoardA();
                MessageBox.Show("Click OK at the top to complete your ship setting", "Ships Complete");
            }
            if (DestroyerA.DestroyerACount() == 2)
            {
                ((Button)sender).BackColor = Color.Orange;
                ((Button)sender).Enabled = false;
                boatSettingPoint1A(sender, e);
                DestroyerA.DestroyerADecrement();
            }
        }
        //handler for player A Ok button that adds the locations of ship into internalboard A object
        private void btnOk1_Click(object sender, EventArgs e)
        {
            btnBCreateBoard.Visible = true;
            btnBCreateBoard.Enabled = true;
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    if (newButtonA[row, col].BackColor == Color.Purple ||
                        newButtonA[row, col].BackColor == Color.Yellow ||
                        newButtonA[row, col].BackColor == Color.Green ||
                        newButtonA[row, col].BackColor == Color.Black || newButtonA[row, col].BackColor == Color.Orange)
                    {
                        PlayerABoard.shiplocationInsert(row, col);
                    }
                }
            }
            lblLETTERS.Visible = false;
            lblNumbers.Visible = false;
            pnlPlayerA.Visible = false;
            pnlBoatCreators.Visible = false;
            btnOk1.Enabled = false;
            lblPlayerB.Visible = true;
            txtPlayerB.Visible = true;
        }
        //Event handler to Create Carrier of Board B
        private void btnCreateCarrierB_Click(object sender, EventArgs e)
        {
            enableBoardB();
            btnBCreateBoard.Enabled = false;
            btnCreateCarrierB.Enabled = false;
            MessageBox.Show("Please click five buttons horizontal or vertical", "Create Carrier");
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonB[row, col].Click += new EventHandler(CreateCarrierB);
                }
            }
        }
        //button click event handler that handles creating carrier of Board B
        private void CreateCarrierB(object sender, EventArgs e)
        {
            if (CarrierB.CarrierBCount() < 5 && CarrierB.CarrierBCount() > 0)
            {
                boatsettingPoint2CarrierB(sender, e);
            }

            if (CarrierB.CarrierBCount() == 0)
            {
                ((Button)sender).BackColor = Color.Purple;
                ((Button)sender).Enabled = false;
                btnCreateBattleshipB.Enabled = true;
                CarrierB.CarrierBDecrement();
                disableBoardB();
                MessageBox.Show("Please click Create Battleship", "Carrier Complete");
            }
            if (CarrierB.CarrierBCount() == 5)
            {
                ((Button)sender).BackColor = Color.Purple;
                ((Button)sender).Enabled = false;
                boatSettingPoint1B(sender, e);
                CarrierB.CarrierBDecrement();
            }
        }
        //Event handler to Create Battleship of Board B
        private void btnCreateBattleshipB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click four buttons horizontal or vertical", "Create Battleship");
            enableBoardB();
            btnCreateBattleshipB.Enabled = false;
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonB[row, col].Click += new EventHandler(CreateBattleShipB);
                }
            }
        }
        //button click event handler that handles creating Battleship of Board B
        public void CreateBattleShipB(object sender, EventArgs e)
        {
            if (BattleshipB.BattleshipBCount() < 4 && BattleshipB.BattleshipBCount() > 0)
            {
                boatsettingPoint2BattleShipB(sender, e);
            }

            if (BattleshipB.BattleshipBCount() == 0)
            {
                ((Button)sender).BackColor = Color.Yellow;
                ((Button)sender).Enabled = false;
                btnCreateCruiserB.Enabled = true;
                BattleshipB.BattleshipBDecrement();
                disableBoardB();
                MessageBox.Show("Please click Create Cruiser", "Battleship Complete");
            }
            if (BattleshipB.BattleshipBCount() == 4)
            {
                ((Button)sender).BackColor = Color.Yellow;
                ((Button)sender).Enabled = false;
                boatSettingPoint1B(sender, e);
                BattleshipB.BattleshipBDecrement();
            }
        }
        //Event handler to Create Cruiser of Board B
        private void btnCreateCruiserB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click three buttons horizontal or vertical", "Create Cruiser");
            btnCreateCruiserB.Enabled = false;
            enableBoardB();
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonB[row, col].Click += new EventHandler(CreateCruiserB);
                }
            }
        }
        //button click event handler that handles creating cruiser of Board B
        private void CreateCruiserB(object sender, EventArgs e)
        {
            if (CruiserB.CruiserBCount() < 3 && CruiserB.CruiserBCount() > 0)
            {
                boatsettingPoint2CruiserB(sender, e);
            }
            if (CruiserB.CruiserBCount() == 0)
            {
                ((Button)sender).BackColor = Color.Green;
                ((Button)sender).Enabled = false;
                btnCreateSubmarineB.Enabled = true;
                CruiserB.CruiserBDecrement();
                disableBoardB();
                MessageBox.Show("Please click Create Submarine", "Cruiser Complete");
            }
            if (CruiserB.CruiserBCount() == 3)
            {
                ((Button)sender).BackColor = Color.Green;
                ((Button)sender).Enabled = false;
                boatSettingPoint1B(sender, e);
                CruiserB.CruiserBDecrement();
            }
        }
        //Event handler to Create Submarine of Board B
        private void btnCreateSubmarineB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click three buttons horizontal or vertical", "Create Submarine");
            btnCreateSubmarineB.Enabled = false;
            enableBoardB();
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonB[row, col].Click += new EventHandler(CreateSubmarineB);
                }
            }
        }
        //button click event handler that handles creating submarine of Board B
        private void CreateSubmarineB(object sender, EventArgs e)
        {
            if (SubmarineB.SubmarineBCount() < 3 && SubmarineB.SubmarineBCount() > 0)
            {
                boatsettingPoint2SubmarineB(sender, e);
            }
            if (SubmarineB.SubmarineBCount() == 0)
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).Enabled = false;
                btnCreateDestroyerB.Enabled = true;
                SubmarineB.SubmarineBDecrement();
                disableBoardB();
                MessageBox.Show("Please click Create Destroyer", "Submarine Complete");
            }
            if (SubmarineB.SubmarineBCount() == 3)
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).Enabled = false;
                boatSettingPoint1B(sender, e);
                SubmarineB.SubmarineBDecrement();
            }
        }
        //Event handler to Create Destroyer of Board B
        private void btnCreateDestroyerB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click two buttons horizontal or vertical", "Create Destroyer");
            btnCreateDestroyerB.Enabled = false;
            enableBoardB();
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonB[row, col].Click += new EventHandler(CreateDestroyerB);
                }
            }
        }
        //button click event handler that handles creating destroyer of Board B
        private void CreateDestroyerB(object sender, EventArgs e)
        {
            if (DestroyerB.DestroyerBCount() < 2 && DestroyerB.DestroyerBCount() > 0)
            {
                boatsettingPoint2DestroyerB(sender, e);
            }
            if (DestroyerB.DestroyerBCount() == 0)
            {
                ((Button)sender).BackColor = Color.Orange;
                ((Button)sender).Enabled = false;
                btnOk2.Visible = true;
                DestroyerB.DestroyerBDecrement();
                disableBoardB();
                MessageBox.Show("Click OK at the top to complete your ship setting", "Ships Complete");
            }
            if (DestroyerB.DestroyerBCount() == 2)
            {
                ((Button)sender).BackColor = Color.Orange;
                ((Button)sender).Enabled = false;
                boatSettingPoint1B(sender, e);
                DestroyerB.DestroyerBDecrement();
            }
        }
        //handler for player two Ok button that adds the locations of ship into internalboard B object
        private void btnOk2_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    if (newButtonB[row, col].BackColor == Color.Purple ||
                        newButtonB[row, col].BackColor == Color.Yellow ||
                        newButtonB[row, col].BackColor == Color.Green ||
                        newButtonB[row, col].BackColor == Color.Black || newButtonB[row, col].BackColor == Color.Orange)
                    {
                        PlayerBBoard.shiplocationInsert(row, col);
                    }
                }
            }
            lblLETTERSB.Visible = false;
            lblNUMBERSB.Visible = false;
            btnOk2.Enabled = false;
            lblReady.Visible = true;
            btnLetsplay.Visible = true;
            pnlPlayerB.Visible = false;
            pnlBuildShipsB.Visible = false;
        }
        //event handler of the completed turn button that switches player turns and decides winner
        private void btnCompletedTurn_Click(object sender, EventArgs e)
        {
            btnCompletedTurn.Enabled = false;
            if (PlayerABoard.isLoser() == false && PlayerBBoard.isLoser() == false)
            {
                if (txtCurrentPlayer.Text == txtPlayerB.Text)
                {
                    lblNumbers.Visible = false;
                    lblLETTERS.Visible = false;
                    lblLETTERSB.Visible = true;
                    lblNUMBERSB.Visible = true;
                    pnlPlayerA.Visible = false;
                    pnlPlayerB.Visible = true;
                    enableBoardB();
                    txtCurrentPlayer.Text = txtPlayerA.Text;
                }
                else
                {

                    lblLETTERSB.Visible = false;
                    lblNUMBERSB.Visible = false;
                    lblLETTERS.Visible = true;
                    lblNumbers.Visible = true;
                    pnlPlayerB.Visible = false;
                    pnlPlayerA.Visible = true;
                    enableBoardA();
                    txtCurrentPlayer.Text = txtPlayerB.Text;
                }
            }
            else
            {
                pnlPlayerA.Visible = false;
                pnlPlayerB.Visible = false;
                btnCompletedTurn.Visible = false;
                MessageBox.Show("Congradulations " + txtCurrentPlayer.Text + " You have won the Game of Battleship!");
                btnExit.Focus();
            }
        }
        //used to reset both board A and B for start of gameplay
        private void resetboards()
        {
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col].BackColor = SystemColors.ButtonFace;
                    newButtonA[row, col].UseVisualStyleBackColor = true;
                    newButtonA[row, col].Enabled = true;
                    newButtonB[row, col].BackColor = SystemColors.ButtonFace;
                    newButtonB[row, col].UseVisualStyleBackColor = true;
                    newButtonB[row, col].Enabled = true;
                }
            }
        }
        //disables all buttons of board A
        public void disableBoardA()
        {
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonA[row, col].Enabled = false;
                }
            }
        }
        //disables all buttons of board B
        public void disableBoardB()
        {
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    newButtonB[row, col].Enabled = false;
                }
            }
        }
        //used for initial point placement of all boats in Board A
        private void boatSettingPoint1A(object sender, EventArgs e)
        {
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            disableBoardA();
            if(newButtonA[Y, X + 1].BackColor == SystemColors.Control) { newButtonA[Y, X + 1].Enabled = true; }
            if(newButtonA[Y, X - 1].BackColor == SystemColors.Control) { newButtonA[Y, X - 1].Enabled = true; }
            if(newButtonA[Y - 1, X].BackColor == SystemColors.Control) { newButtonA[Y - 1, X].Enabled = true; }
            if(newButtonA[Y + 1, X].BackColor == SystemColors.Control) { newButtonA[Y + 1, X].Enabled = true; }
        }
        //button click event handler for Carrier placements after first button click in Board A
        private void boatsettingPoint2CarrierA(object sender, EventArgs e)
        {
            disableBoardA();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonA[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonA[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonA[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonA[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Purple;
                ((Button)sender).Enabled = false;
                if (newButtonA[Y - 1, X].BackColor == Color.Purple)
                {
                    newButtonA[Y + 1, X].Enabled = true;
                }
                if (newButtonA[Y + 1, X].BackColor == Color.Purple)
                {
                    newButtonA[Y - 1, X].Enabled = true;
                }
                if (newButtonA[Y, X + 1].BackColor == Color.Purple)
                {
                    newButtonA[Y, X - 1].Enabled = true;
                }
                if (newButtonA[Y, X - 1].BackColor == Color.Purple)
                {
                    newButtonA[Y, X + 1].Enabled = true;
                }

                CarrierA.CarrierADecrement();
            }
        }
        //button click event handler for Battleship placements after first button click in Board A
        private void boatsettingPoint2BattleShipA(object sender, EventArgs e)
        {
            disableBoardA();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonA[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonA[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonA[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonA[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Yellow;
                ((Button)sender).Enabled = false;
                if (newButtonA[Y - 1, X].BackColor == Color.Yellow)
                {
                    newButtonA[Y + 1, X].Enabled = true;
                }
                if (newButtonA[Y + 1, X].BackColor == Color.Yellow)
                {
                    newButtonA[Y - 1, X].Enabled = true;
                }
                if (newButtonA[Y, X + 1].BackColor == Color.Yellow)
                {
                    newButtonA[Y, X - 1].Enabled = true;
                }
                if (newButtonA[Y, X - 1].BackColor == Color.Yellow)
                {
                    newButtonA[Y, X + 1].Enabled = true;
                }
                BattleshipA.BattleshipADecrement();
            }
        }
        //button click event handler for Cruiser placements after first button click in Board A
        private void boatsettingPoint2CruiserA(object sender, EventArgs e)
        {
            disableBoardA();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonA[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonA[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonA[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonA[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Green;
                ((Button)sender).Enabled = false;
                if (newButtonA[Y - 1, X].BackColor == Color.Green)
                {
                    newButtonA[Y + 1, X].Enabled = true;
                }
                if (newButtonA[Y + 1, X].BackColor == Color.Green)
                {
                    newButtonA[Y - 1, X].Enabled = true;
                }
                if (newButtonA[Y, X + 1].BackColor == Color.Green)
                {
                    newButtonA[Y, X - 1].Enabled = true;
                }
                if (newButtonA[Y, X - 1].BackColor == Color.Green)
                {
                    newButtonA[Y, X + 1].Enabled = true;
                }
                CruiserA.CruiserADecrement();
            }
        }
        //button click event handler for Submarine placements after first button click in Board A
        private void boatsettingPoint2SubmarineA(object sender, EventArgs e)
        {
            disableBoardA();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonA[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonA[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonA[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonA[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).Enabled = false;
                if (newButtonA[Y - 1, X].BackColor == Color.Black)
                {
                    newButtonA[Y + 1, X].Enabled = true;
                }
                if (newButtonA[Y + 1, X].BackColor == Color.Black)
                {
                    newButtonA[Y - 1, X].Enabled = true;
                }
                if (newButtonA[Y, X + 1].BackColor == Color.Black)
                {
                    newButtonA[Y, X - 1].Enabled = true;
                }
                if (newButtonA[Y, X - 1].BackColor == Color.Black)
                {
                    newButtonA[Y, X + 1].Enabled = true;
                }
                SubmarineA.SubmarineADecrement();
            }
        }
        //button click event handler for Destroyer placements after first button click in Board A
        private void boatsettingPoint2DestroyerA(object sender, EventArgs e)
        {
            disableBoardA();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonA[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonA[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonA[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonA[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Orange;
                ((Button)sender).Enabled = false;
                if (newButtonA[Y - 1, X].BackColor == Color.Orange)
                {
                    newButtonA[Y + 1, X].Enabled = true;
                }
                if (newButtonA[Y + 1, X].BackColor == Color.Orange)
                {
                    newButtonA[Y - 1, X].Enabled = true;
                }
                if (newButtonA[Y, X + 1].BackColor == Color.Orange)
                {
                    newButtonA[Y, X - 1].Enabled = true;
                }
                if (newButtonA[Y, X - 1].BackColor == Color.Orange)
                {
                    newButtonA[Y, X + 1].Enabled = true;
                }
                DestroyerA.DestroyerADecrement();
            }
        }
        //used for initial point placement of all boats in Board B
        private void boatSettingPoint1B(object sender, EventArgs e)
        {
            disableBoardB();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonB[Y, X + 1].BackColor == SystemColors.Control) { newButtonB[Y, X + 1].Enabled = true; }
            if (newButtonB[Y, X - 1].BackColor == SystemColors.Control) { newButtonB[Y, X - 1].Enabled = true; }
            if (newButtonB[Y - 1, X].BackColor == SystemColors.Control) { newButtonB[Y - 1, X].Enabled = true; }
            if (newButtonB[Y + 1, X].BackColor == SystemColors.Control) { newButtonB[Y + 1, X].Enabled = true; }
        }
        //button click event handler for Carrier placements after first button click in Board B
        private void boatsettingPoint2CarrierB(object sender, EventArgs e)
        {
            disableBoardB();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonB[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonB[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonB[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonB[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Purple;
                ((Button)sender).Enabled = false;
                if (newButtonB[Y - 1, X].BackColor == Color.Purple)
                {
                    newButtonB[Y + 1, X].Enabled = true;
                }
                if (newButtonB[Y + 1, X].BackColor == Color.Purple)
                {
                    newButtonB[Y - 1, X].Enabled = true;
                }
                if (newButtonB[Y, X + 1].BackColor == Color.Purple)
                {
                    newButtonB[Y, X - 1].Enabled = true;
                }
                if (newButtonB[Y, X - 1].BackColor == Color.Purple)
                {
                    newButtonB[Y, X + 1].Enabled = true;
                }
                CarrierB.CarrierBDecrement();
            }
        }
        //button click event handler for Battlehip placements after first button click in Board B
        private void boatsettingPoint2BattleShipB(object sender, EventArgs e)
        {
            disableBoardB();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonB[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonB[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonB[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonB[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Yellow;
                ((Button)sender).Enabled = false;
                if (newButtonB[Y - 1, X].BackColor == Color.Yellow)
                {
                    newButtonB[Y + 1, X].Enabled = true;
                }
                if (newButtonB[Y + 1, X].BackColor == Color.Yellow)
                {
                    newButtonB[Y - 1, X].Enabled = true;
                }
                if (newButtonB[Y, X + 1].BackColor == Color.Yellow)
                {
                    newButtonB[Y, X - 1].Enabled = true;
                }
                if (newButtonB[Y, X - 1].BackColor == Color.Yellow)
                {
                    newButtonB[Y, X + 1].Enabled = true;
                }
                BattleshipB.BattleshipBDecrement();
            }
        }
        //button click event handler for Cruiser placements after first button click in Board B
        private void boatsettingPoint2CruiserB(object sender, EventArgs e)
        {
            disableBoardB();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonB[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonB[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonB[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonB[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Green;
                ((Button)sender).Enabled = false;
                if (newButtonB[Y - 1, X].BackColor == Color.Green)
                {
                    newButtonB[Y + 1, X].Enabled = true;
                }
                if (newButtonB[Y + 1, X].BackColor == Color.Green)
                {
                    newButtonB[Y - 1, X].Enabled = true;
                }
                if (newButtonB[Y, X + 1].BackColor == Color.Green)
                {
                    newButtonB[Y, X - 1].Enabled = true;
                }
                if (newButtonB[Y, X - 1].BackColor == Color.Green)
                {
                    newButtonB[Y, X + 1].Enabled = true;
                }
                CruiserB.CruiserBDecrement();
            }
        }
        //button click event handler for Submarine placements after first button click in Board B
        private void boatsettingPoint2SubmarineB(object sender, EventArgs e)
        {
            disableBoardB();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonB[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonB[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonB[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonB[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).Enabled = false;
                if (newButtonB[Y - 1, X].BackColor == Color.Black)
                {
                    newButtonB[Y + 1, X].Enabled = true;
                }
                if (newButtonB[Y + 1, X].BackColor == Color.Black)
                {
                    newButtonB[Y - 1, X].Enabled = true;
                }
                if (newButtonB[Y, X + 1].BackColor == Color.Black)
                {
                    newButtonB[Y, X - 1].Enabled = true;
                }
                if (newButtonB[Y, X - 1].BackColor == Color.Black)
                {
                    newButtonB[Y, X + 1].Enabled = true;
                }
                SubmarineB.SubmarineBDecrement();
            }
        }
        //button click event handler for Destroyer placements after first button click in Board B
        private void boatsettingPoint2DestroyerB(object sender, EventArgs e)
        {
            disableBoardB();
            Button invalid = (sender as Button);
            int Y = invalid.Location.Y / 35;
            int X = invalid.Location.X / 35;
            if (newButtonB[Y, X + 1].BackColor != SystemColors.Control ||
                newButtonB[Y, X - 1].BackColor != SystemColors.Control ||
                newButtonB[Y - 1, X].BackColor != SystemColors.Control ||
                newButtonB[Y + 1, X].BackColor != SystemColors.Control)
            {
                ((Button)sender).BackColor = Color.Orange;
                ((Button)sender).Enabled = false;
                if (newButtonB[Y - 1, X].BackColor == Color.Orange)
                {
                    newButtonB[Y + 1, X].Enabled = true;
                }
                if (newButtonB[Y + 1, X].BackColor == Color.Orange)
                {
                    newButtonB[Y - 1, X].Enabled = true;
                }
                if (newButtonB[Y, X + 1].BackColor == Color.Orange)
                {
                    newButtonB[Y, X - 1].Enabled = true;
                }
                if (newButtonB[Y, X - 1].BackColor == Color.Orange)
                {
                    newButtonB[Y, X + 1].Enabled = true;
                }
                DestroyerB.DestroyerBDecrement();
            }
        }
    }
}
