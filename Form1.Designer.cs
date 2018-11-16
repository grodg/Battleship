namespace Battleship
{
    partial class frmBattleShip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPlayerA = new System.Windows.Forms.Label();
            this.txtPlayerA = new System.Windows.Forms.TextBox();
            this.lblPlayerB = new System.Windows.Forms.Label();
            this.txtPlayerB = new System.Windows.Forms.TextBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.button64 = new System.Windows.Forms.Button();
            this.button127 = new System.Windows.Forms.Button();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnLetsplay = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.btnACreateBoard = new System.Windows.Forms.Button();
            this.btnOk1 = new System.Windows.Forms.Button();
            this.btnBCreateBoard = new System.Windows.Forms.Button();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.pnlPlayerA = new System.Windows.Forms.Panel();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblLETTERS = new System.Windows.Forms.Label();
            this.pnlPlayerB = new System.Windows.Forms.Panel();
            this.lblNUMBERSB = new System.Windows.Forms.Label();
            this.lblLETTERSB = new System.Windows.Forms.Label();
            this.btnCompletedTurn = new System.Windows.Forms.Button();
            this.btnCreateCarrierA = new System.Windows.Forms.Button();
            this.btnCreateBattleshipA = new System.Windows.Forms.Button();
            this.btnCreateCruiserA = new System.Windows.Forms.Button();
            this.btnCreateSubmarineA = new System.Windows.Forms.Button();
            this.btnCreateDestroyerA = new System.Windows.Forms.Button();
            this.pnlBoatCreators = new System.Windows.Forms.Panel();
            this.pnlBuildShipsB = new System.Windows.Forms.Panel();
            this.btnCreateDestroyerB = new System.Windows.Forms.Button();
            this.btnCreateSubmarineB = new System.Windows.Forms.Button();
            this.btnCreateCruiserB = new System.Windows.Forms.Button();
            this.btnCreateBattleshipB = new System.Windows.Forms.Button();
            this.btnCreateCarrierB = new System.Windows.Forms.Button();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.pnlKey.SuspendLayout();
            this.pnlPlayerA.SuspendLayout();
            this.pnlPlayerB.SuspendLayout();
            this.pnlBoatCreators.SuspendLayout();
            this.pnlBuildShipsB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblWelcome.Location = new System.Drawing.Point(53, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(184, 18);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to BattleShip!";
            // 
            // lblPlayerA
            // 
            this.lblPlayerA.AutoSize = true;
            this.lblPlayerA.Location = new System.Drawing.Point(56, 39);
            this.lblPlayerA.Name = "lblPlayerA";
            this.lblPlayerA.Size = new System.Drawing.Size(80, 13);
            this.lblPlayerA.TabIndex = 1;
            this.lblPlayerA.Text = "Player Name A:";
            // 
            // txtPlayerA
            // 
            this.txtPlayerA.Location = new System.Drawing.Point(166, 36);
            this.txtPlayerA.Name = "txtPlayerA";
            this.txtPlayerA.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerA.TabIndex = 2;
            this.txtPlayerA.Text = "Gavin";
            // 
            // lblPlayerB
            // 
            this.lblPlayerB.AutoSize = true;
            this.lblPlayerB.Location = new System.Drawing.Point(56, 70);
            this.lblPlayerB.Name = "lblPlayerB";
            this.lblPlayerB.Size = new System.Drawing.Size(80, 13);
            this.lblPlayerB.TabIndex = 4;
            this.lblPlayerB.Text = "Player Name B:";
            this.lblPlayerB.Visible = false;
            // 
            // txtPlayerB
            // 
            this.txtPlayerB.Location = new System.Drawing.Point(166, 67);
            this.txtPlayerB.Name = "txtPlayerB";
            this.txtPlayerB.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerB.TabIndex = 5;
            this.txtPlayerB.Text = "Louie";
            this.txtPlayerB.Visible = false;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(53, 131);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(101, 13);
            this.lblCurrentPlayer.TabIndex = 8;
            this.lblCurrentPlayer.Text = "Current Player Turn:";
            this.lblCurrentPlayer.Visible = false;
            // 
            // button64
            // 
            this.button64.BackColor = System.Drawing.Color.Blue;
            this.button64.Enabled = false;
            this.button64.Location = new System.Drawing.Point(98, 39);
            this.button64.Name = "button64";
            this.button64.Size = new System.Drawing.Size(20, 23);
            this.button64.TabIndex = 74;
            this.button64.UseVisualStyleBackColor = false;
            // 
            // button127
            // 
            this.button127.BackColor = System.Drawing.Color.Red;
            this.button127.Enabled = false;
            this.button127.Location = new System.Drawing.Point(98, 16);
            this.button127.Name = "button127";
            this.button127.Size = new System.Drawing.Size(20, 23);
            this.button127.TabIndex = 160;
            this.button127.UseVisualStyleBackColor = false;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Location = new System.Drawing.Point(56, 101);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(79, 13);
            this.lblReady.TabIndex = 197;
            this.lblReady.Text = "Ready to Play?";
            this.lblReady.Visible = false;
            // 
            // btnLetsplay
            // 
            this.btnLetsplay.Location = new System.Drawing.Point(165, 96);
            this.btnLetsplay.Name = "btnLetsplay";
            this.btnLetsplay.Size = new System.Drawing.Size(75, 23);
            this.btnLetsplay.TabIndex = 198;
            this.btnLetsplay.Text = "Lets Play!!";
            this.btnLetsplay.UseVisualStyleBackColor = true;
            this.btnLetsplay.Visible = false;
            this.btnLetsplay.Click += new System.EventHandler(this.btnLetsplay_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 199;
            this.label12.Text = "Game Key:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 200;
            this.label13.Text = "Red Button: Hit ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 201;
            this.label14.Text = "Blue Button: Miss";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 202;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(453, 544);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 203;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.button186_Click);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.label15);
            this.pnlKey.Controls.Add(this.label14);
            this.pnlKey.Controls.Add(this.label13);
            this.pnlKey.Controls.Add(this.label12);
            this.pnlKey.Controls.Add(this.button127);
            this.pnlKey.Controls.Add(this.button64);
            this.pnlKey.Location = new System.Drawing.Point(503, 27);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(138, 65);
            this.pnlKey.TabIndex = 204;
            this.pnlKey.Visible = false;
            // 
            // btnACreateBoard
            // 
            this.btnACreateBoard.Location = new System.Drawing.Point(282, 34);
            this.btnACreateBoard.Name = "btnACreateBoard";
            this.btnACreateBoard.Size = new System.Drawing.Size(87, 23);
            this.btnACreateBoard.TabIndex = 205;
            this.btnACreateBoard.Text = "Create Board";
            this.btnACreateBoard.UseVisualStyleBackColor = true;
            this.btnACreateBoard.Click += new System.EventHandler(this.btnPlayerAGenerate_Click);
            // 
            // btnOk1
            // 
            this.btnOk1.Location = new System.Drawing.Point(375, 34);
            this.btnOk1.Name = "btnOk1";
            this.btnOk1.Size = new System.Drawing.Size(30, 23);
            this.btnOk1.TabIndex = 206;
            this.btnOk1.Text = "OK";
            this.btnOk1.UseVisualStyleBackColor = true;
            this.btnOk1.Visible = false;
            this.btnOk1.Click += new System.EventHandler(this.btnOk1_Click);
            // 
            // btnBCreateBoard
            // 
            this.btnBCreateBoard.Location = new System.Drawing.Point(282, 65);
            this.btnBCreateBoard.Name = "btnBCreateBoard";
            this.btnBCreateBoard.Size = new System.Drawing.Size(87, 23);
            this.btnBCreateBoard.TabIndex = 207;
            this.btnBCreateBoard.Text = "Create Board";
            this.btnBCreateBoard.UseVisualStyleBackColor = true;
            this.btnBCreateBoard.Visible = false;
            this.btnBCreateBoard.Click += new System.EventHandler(this.btnPlayerBGenerate_Click);
            // 
            // btnOk2
            // 
            this.btnOk2.Location = new System.Drawing.Point(375, 65);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(30, 23);
            this.btnOk2.TabIndex = 208;
            this.btnOk2.Text = "OK";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Visible = false;
            this.btnOk2.Click += new System.EventHandler(this.btnOk2_Click);
            // 
            // pnlPlayerA
            // 
            this.pnlPlayerA.Controls.Add(this.lblNumbers);
            this.pnlPlayerA.Controls.Add(this.lblLETTERS);
            this.pnlPlayerA.Location = new System.Drawing.Point(12, 147);
            this.pnlPlayerA.Name = "pnlPlayerA";
            this.pnlPlayerA.Size = new System.Drawing.Size(427, 445);
            this.pnlPlayerA.TabIndex = 209;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(30, 58);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(19, 364);
            this.lblNumbers.TabIndex = 221;
            this.lblNumbers.Text = "1\r\n\r\n\r\n2\r\n\r\n\r\n3\r\n\r\n\r\n4\r\n\r\n\r\n5\r\n\r\n\r\n6\r\n\r\n\r\n7\r\n\r\n\r\n8\r\n\r\n\r\n9\r\n\r\n\r\n10";
            this.lblNumbers.Visible = false;
            // 
            // lblLETTERS
            // 
            this.lblLETTERS.AutoSize = true;
            this.lblLETTERS.Location = new System.Drawing.Point(71, 36);
            this.lblLETTERS.Name = "lblLETTERS";
            this.lblLETTERS.Size = new System.Drawing.Size(352, 13);
            this.lblLETTERS.TabIndex = 0;
            this.lblLETTERS.Text = "A         B         C          D          E          F          G          H     " +
    "      I           J   ";
            this.lblLETTERS.Visible = false;
            // 
            // pnlPlayerB
            // 
            this.pnlPlayerB.Controls.Add(this.lblNUMBERSB);
            this.pnlPlayerB.Controls.Add(this.lblLETTERSB);
            this.pnlPlayerB.Location = new System.Drawing.Point(550, 131);
            this.pnlPlayerB.Name = "pnlPlayerB";
            this.pnlPlayerB.Size = new System.Drawing.Size(435, 461);
            this.pnlPlayerB.TabIndex = 0;
            this.pnlPlayerB.Visible = false;
            // 
            // lblNUMBERSB
            // 
            this.lblNUMBERSB.AutoSize = true;
            this.lblNUMBERSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUMBERSB.Location = new System.Drawing.Point(32, 67);
            this.lblNUMBERSB.Name = "lblNUMBERSB";
            this.lblNUMBERSB.Size = new System.Drawing.Size(19, 364);
            this.lblNUMBERSB.TabIndex = 225;
            this.lblNUMBERSB.Text = "1\r\n\r\n\r\n2\r\n\r\n\r\n3\r\n\r\n\r\n4\r\n\r\n\r\n5\r\n\r\n\r\n6\r\n\r\n\r\n7\r\n\r\n\r\n8\r\n\r\n\r\n9\r\n\r\n\r\n10";
            this.lblNUMBERSB.Visible = false;
            // 
            // lblLETTERSB
            // 
            this.lblLETTERSB.AutoSize = true;
            this.lblLETTERSB.Location = new System.Drawing.Point(76, 43);
            this.lblLETTERSB.Name = "lblLETTERSB";
            this.lblLETTERSB.Size = new System.Drawing.Size(352, 13);
            this.lblLETTERSB.TabIndex = 226;
            this.lblLETTERSB.Text = "A         B         C          D          E          F          G          H     " +
    "      I           J   ";
            this.lblLETTERSB.Visible = false;
            // 
            // btnCompletedTurn
            // 
            this.btnCompletedTurn.BackColor = System.Drawing.Color.Green;
            this.btnCompletedTurn.Enabled = false;
            this.btnCompletedTurn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompletedTurn.Location = new System.Drawing.Point(453, 472);
            this.btnCompletedTurn.Name = "btnCompletedTurn";
            this.btnCompletedTurn.Size = new System.Drawing.Size(73, 52);
            this.btnCompletedTurn.TabIndex = 210;
            this.btnCompletedTurn.Text = "Completed Turn";
            this.btnCompletedTurn.UseVisualStyleBackColor = false;
            this.btnCompletedTurn.Visible = false;
            this.btnCompletedTurn.Click += new System.EventHandler(this.btnCompletedTurn_Click);
            // 
            // btnCreateCarrierA
            // 
            this.btnCreateCarrierA.BackColor = System.Drawing.Color.Purple;
            this.btnCreateCarrierA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCarrierA.Location = new System.Drawing.Point(3, 6);
            this.btnCreateCarrierA.Name = "btnCreateCarrierA";
            this.btnCreateCarrierA.Size = new System.Drawing.Size(108, 23);
            this.btnCreateCarrierA.TabIndex = 211;
            this.btnCreateCarrierA.Text = "Create Carrier";
            this.btnCreateCarrierA.UseVisualStyleBackColor = false;
            this.btnCreateCarrierA.Click += new System.EventHandler(this.btnCreateCarrierA_click);
            // 
            // btnCreateBattleshipA
            // 
            this.btnCreateBattleshipA.BackColor = System.Drawing.Color.Yellow;
            this.btnCreateBattleshipA.Enabled = false;
            this.btnCreateBattleshipA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateBattleshipA.Location = new System.Drawing.Point(4, 36);
            this.btnCreateBattleshipA.Name = "btnCreateBattleshipA";
            this.btnCreateBattleshipA.Size = new System.Drawing.Size(107, 23);
            this.btnCreateBattleshipA.TabIndex = 213;
            this.btnCreateBattleshipA.Text = "Create Battleship";
            this.btnCreateBattleshipA.UseVisualStyleBackColor = false;
            this.btnCreateBattleshipA.Click += new System.EventHandler(this.btnCreateBattleshipA_Click);
            // 
            // btnCreateCruiserA
            // 
            this.btnCreateCruiserA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreateCruiserA.Enabled = false;
            this.btnCreateCruiserA.Location = new System.Drawing.Point(4, 65);
            this.btnCreateCruiserA.Name = "btnCreateCruiserA";
            this.btnCreateCruiserA.Size = new System.Drawing.Size(107, 23);
            this.btnCreateCruiserA.TabIndex = 214;
            this.btnCreateCruiserA.Text = "Create Cruiser";
            this.btnCreateCruiserA.UseVisualStyleBackColor = false;
            this.btnCreateCruiserA.Click += new System.EventHandler(this.btnCreateCruiserA_Click);
            // 
            // btnCreateSubmarineA
            // 
            this.btnCreateSubmarineA.BackColor = System.Drawing.Color.Black;
            this.btnCreateSubmarineA.Enabled = false;
            this.btnCreateSubmarineA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateSubmarineA.Location = new System.Drawing.Point(4, 94);
            this.btnCreateSubmarineA.Name = "btnCreateSubmarineA";
            this.btnCreateSubmarineA.Size = new System.Drawing.Size(107, 23);
            this.btnCreateSubmarineA.TabIndex = 215;
            this.btnCreateSubmarineA.Text = "Create Submarine";
            this.btnCreateSubmarineA.UseVisualStyleBackColor = false;
            this.btnCreateSubmarineA.Click += new System.EventHandler(this.btnCreateSubmarineA_Click_1);
            // 
            // btnCreateDestroyerA
            // 
            this.btnCreateDestroyerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateDestroyerA.Enabled = false;
            this.btnCreateDestroyerA.Location = new System.Drawing.Point(4, 123);
            this.btnCreateDestroyerA.Name = "btnCreateDestroyerA";
            this.btnCreateDestroyerA.Size = new System.Drawing.Size(107, 23);
            this.btnCreateDestroyerA.TabIndex = 216;
            this.btnCreateDestroyerA.Text = "Create Destroyer";
            this.btnCreateDestroyerA.UseVisualStyleBackColor = false;
            this.btnCreateDestroyerA.Click += new System.EventHandler(this.btnCreateDestroyerA_Click);
            // 
            // pnlBoatCreators
            // 
            this.pnlBoatCreators.Controls.Add(this.btnCreateDestroyerA);
            this.pnlBoatCreators.Controls.Add(this.btnCreateSubmarineA);
            this.pnlBoatCreators.Controls.Add(this.btnCreateCruiserA);
            this.pnlBoatCreators.Controls.Add(this.btnCreateBattleshipA);
            this.pnlBoatCreators.Controls.Add(this.btnCreateCarrierA);
            this.pnlBoatCreators.Location = new System.Drawing.Point(438, 297);
            this.pnlBoatCreators.Name = "pnlBoatCreators";
            this.pnlBoatCreators.Size = new System.Drawing.Size(112, 153);
            this.pnlBoatCreators.TabIndex = 222;
            this.pnlBoatCreators.Visible = false;
            // 
            // pnlBuildShipsB
            // 
            this.pnlBuildShipsB.Controls.Add(this.btnCreateDestroyerB);
            this.pnlBuildShipsB.Controls.Add(this.btnCreateSubmarineB);
            this.pnlBuildShipsB.Controls.Add(this.btnCreateCruiserB);
            this.pnlBuildShipsB.Controls.Add(this.btnCreateBattleshipB);
            this.pnlBuildShipsB.Controls.Add(this.btnCreateCarrierB);
            this.pnlBuildShipsB.Location = new System.Drawing.Point(435, 137);
            this.pnlBuildShipsB.Name = "pnlBuildShipsB";
            this.pnlBuildShipsB.Size = new System.Drawing.Size(113, 154);
            this.pnlBuildShipsB.TabIndex = 224;
            this.pnlBuildShipsB.Visible = false;
            // 
            // btnCreateDestroyerB
            // 
            this.btnCreateDestroyerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateDestroyerB.Enabled = false;
            this.btnCreateDestroyerB.Location = new System.Drawing.Point(3, 120);
            this.btnCreateDestroyerB.Name = "btnCreateDestroyerB";
            this.btnCreateDestroyerB.Size = new System.Drawing.Size(107, 23);
            this.btnCreateDestroyerB.TabIndex = 4;
            this.btnCreateDestroyerB.Text = "Create Destroyer";
            this.btnCreateDestroyerB.UseVisualStyleBackColor = false;
            this.btnCreateDestroyerB.Click += new System.EventHandler(this.btnCreateDestroyerB_Click);
            // 
            // btnCreateSubmarineB
            // 
            this.btnCreateSubmarineB.BackColor = System.Drawing.Color.Black;
            this.btnCreateSubmarineB.Enabled = false;
            this.btnCreateSubmarineB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateSubmarineB.Location = new System.Drawing.Point(3, 91);
            this.btnCreateSubmarineB.Name = "btnCreateSubmarineB";
            this.btnCreateSubmarineB.Size = new System.Drawing.Size(107, 23);
            this.btnCreateSubmarineB.TabIndex = 3;
            this.btnCreateSubmarineB.Text = "Create Submarine";
            this.btnCreateSubmarineB.UseVisualStyleBackColor = false;
            this.btnCreateSubmarineB.Click += new System.EventHandler(this.btnCreateSubmarineB_Click);
            // 
            // btnCreateCruiserB
            // 
            this.btnCreateCruiserB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreateCruiserB.Enabled = false;
            this.btnCreateCruiserB.Location = new System.Drawing.Point(3, 61);
            this.btnCreateCruiserB.Name = "btnCreateCruiserB";
            this.btnCreateCruiserB.Size = new System.Drawing.Size(107, 23);
            this.btnCreateCruiserB.TabIndex = 2;
            this.btnCreateCruiserB.Text = "Create Cruiser";
            this.btnCreateCruiserB.UseVisualStyleBackColor = false;
            this.btnCreateCruiserB.Click += new System.EventHandler(this.btnCreateCruiserB_Click);
            // 
            // btnCreateBattleshipB
            // 
            this.btnCreateBattleshipB.BackColor = System.Drawing.Color.Yellow;
            this.btnCreateBattleshipB.Enabled = false;
            this.btnCreateBattleshipB.Location = new System.Drawing.Point(3, 32);
            this.btnCreateBattleshipB.Name = "btnCreateBattleshipB";
            this.btnCreateBattleshipB.Size = new System.Drawing.Size(107, 23);
            this.btnCreateBattleshipB.TabIndex = 1;
            this.btnCreateBattleshipB.Text = "Create Battleship";
            this.btnCreateBattleshipB.UseVisualStyleBackColor = false;
            this.btnCreateBattleshipB.Click += new System.EventHandler(this.btnCreateBattleshipB_Click);
            // 
            // btnCreateCarrierB
            // 
            this.btnCreateCarrierB.BackColor = System.Drawing.Color.Purple;
            this.btnCreateCarrierB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateCarrierB.Location = new System.Drawing.Point(3, 3);
            this.btnCreateCarrierB.Name = "btnCreateCarrierB";
            this.btnCreateCarrierB.Size = new System.Drawing.Size(107, 23);
            this.btnCreateCarrierB.TabIndex = 0;
            this.btnCreateCarrierB.Text = "Create Carrier";
            this.btnCreateCarrierB.UseVisualStyleBackColor = false;
            this.btnCreateCarrierB.Click += new System.EventHandler(this.btnCreateCarrierB_Click);
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Location = new System.Drawing.Point(160, 124);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.ReadOnly = true;
            this.txtCurrentPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPlayer.TabIndex = 223;
            this.txtCurrentPlayer.Visible = false;
            // 
            // frmBattleShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.pnlPlayerB);
            this.Controls.Add(this.pnlBuildShipsB);
            this.Controls.Add(this.pnlBoatCreators);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.btnCompletedTurn);
            this.Controls.Add(this.pnlPlayerA);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.btnBCreateBoard);
            this.Controls.Add(this.btnOk1);
            this.Controls.Add(this.btnACreateBoard);
            this.Controls.Add(this.pnlKey);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLetsplay);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.txtPlayerB);
            this.Controls.Add(this.lblPlayerB);
            this.Controls.Add(this.txtPlayerA);
            this.Controls.Add(this.lblPlayerA);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmBattleShip";
            this.Text = "BattleShip";
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            this.pnlPlayerA.ResumeLayout(false);
            this.pnlPlayerA.PerformLayout();
            this.pnlPlayerB.ResumeLayout(false);
            this.pnlPlayerB.PerformLayout();
            this.pnlBoatCreators.ResumeLayout(false);
            this.pnlBuildShipsB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPlayerA;
        private System.Windows.Forms.TextBox txtPlayerA;
        private System.Windows.Forms.Label lblPlayerB;
        private System.Windows.Forms.TextBox txtPlayerB;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Button button64;
        private System.Windows.Forms.Button button127;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnLetsplay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlKey;
        private System.Windows.Forms.Button btnACreateBoard;
        private System.Windows.Forms.Button btnOk1;
        private System.Windows.Forms.Button btnBCreateBoard;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Panel pnlPlayerA;
        private System.Windows.Forms.Button btnCompletedTurn;
        private System.Windows.Forms.Button btnCreateCarrierA;
        private System.Windows.Forms.Button btnCreateBattleshipA;
        private System.Windows.Forms.Button btnCreateCruiserA;
        private System.Windows.Forms.Button btnCreateSubmarineA;
        private System.Windows.Forms.Button btnCreateDestroyerA;
        private System.Windows.Forms.Label lblLETTERS;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Panel pnlBoatCreators;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Panel pnlBuildShipsB;
        private System.Windows.Forms.Button btnCreateDestroyerB;
        private System.Windows.Forms.Button btnCreateSubmarineB;
        private System.Windows.Forms.Button btnCreateCruiserB;
        private System.Windows.Forms.Button btnCreateBattleshipB;
        private System.Windows.Forms.Button btnCreateCarrierB;
        private System.Windows.Forms.Panel pnlPlayerB;
        private System.Windows.Forms.Label lblNUMBERSB;
        private System.Windows.Forms.Label lblLETTERSB;
    }
}

