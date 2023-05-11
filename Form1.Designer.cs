namespace Tic_Tac_Toe
{
    partial class Form1
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
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.singleButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.sgamePanel = new System.Windows.Forms.Panel();
            this.computerLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.endgamePanel = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.endgameMessageLabel = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.sgamePanel.SuspendLayout();
            this.endgamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuLabel.Font = new System.Drawing.Font("Ink Free", 55F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.mainMenuLabel.Location = new System.Drawing.Point(127, 36);
            this.mainMenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(527, 128);
            this.mainMenuLabel.TabIndex = 0;
            this.mainMenuLabel.Text = "Tic Tac Toe";
            this.mainMenuLabel.UseCompatibleTextRendering = true;
            this.mainMenuLabel.Click += new System.EventHandler(this.mainMenuLabel_Click);
            // 
            // singleButton
            // 
            this.singleButton.BackColor = System.Drawing.Color.Gold;
            this.singleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singleButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleButton.Location = new System.Drawing.Point(77, 307);
            this.singleButton.Margin = new System.Windows.Forms.Padding(2);
            this.singleButton.Name = "singleButton";
            this.singleButton.Size = new System.Drawing.Size(161, 68);
            this.singleButton.TabIndex = 1;
            this.singleButton.Text = "Single Player";
            this.singleButton.UseVisualStyleBackColor = false;
            this.singleButton.Click += new System.EventHandler(this.singleButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.BackColor = System.Drawing.Color.YellowGreen;
            this.multiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiButton.Location = new System.Drawing.Point(511, 307);
            this.multiButton.Margin = new System.Windows.Forms.Padding(2);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(161, 68);
            this.multiButton.TabIndex = 2;
            this.multiButton.Text = "Multiplayer";
            this.multiButton.UseVisualStyleBackColor = false;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // sgamePanel
            // 
            this.sgamePanel.BackColor = System.Drawing.Color.Transparent;
            this.sgamePanel.Controls.Add(this.computerLabel);
            this.sgamePanel.Controls.Add(this.turnLabel);
            this.sgamePanel.Controls.Add(this.button9);
            this.sgamePanel.Controls.Add(this.button8);
            this.sgamePanel.Controls.Add(this.button7);
            this.sgamePanel.Controls.Add(this.button6);
            this.sgamePanel.Controls.Add(this.button5);
            this.sgamePanel.Controls.Add(this.button4);
            this.sgamePanel.Controls.Add(this.button3);
            this.sgamePanel.Controls.Add(this.button2);
            this.sgamePanel.Controls.Add(this.button1);
            this.sgamePanel.Controls.Add(this.player2Label);
            this.sgamePanel.Controls.Add(this.player1Label);
            this.sgamePanel.Location = new System.Drawing.Point(3, 2);
            this.sgamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sgamePanel.Name = "sgamePanel";
            this.sgamePanel.Size = new System.Drawing.Size(782, 462);
            this.sgamePanel.TabIndex = 3;
            this.sgamePanel.Visible = false;
            this.sgamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.ForeColor = System.Drawing.Color.Yellow;
            this.computerLabel.Location = new System.Drawing.Point(628, 29);
            this.computerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(136, 25);
            this.computerLabel.TabIndex = 12;
            this.computerLabel.Text = "Computer : O";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.turnLabel.Location = new System.Drawing.Point(267, 426);
            this.turnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(213, 32);
            this.turnLabel.TabIndex = 11;
            this.turnLabel.Text = "Your turn player: 1";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.Yellow;
            this.button9.Location = new System.Drawing.Point(497, 306);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 102);
            this.button9.TabIndex = 10;
            this.button9.Text = "O";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(329, 306);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 102);
            this.button8.TabIndex = 9;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(175, 306);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 102);
            this.button7.TabIndex = 8;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(497, 167);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 102);
            this.button6.TabIndex = 7;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(329, 167);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 102);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(175, 167);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 102);
            this.button4.TabIndex = 5;
            this.button4.Text = "O";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(497, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 102);
            this.button3.TabIndex = 4;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(329, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 102);
            this.button2.TabIndex = 3;
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(175, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 102);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.ForeColor = System.Drawing.Color.Yellow;
            this.player2Label.Location = new System.Drawing.Point(628, 29);
            this.player2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(126, 25);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "Player 2 : O";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.ForeColor = System.Drawing.Color.Red;
            this.player1Label.Location = new System.Drawing.Point(36, 29);
            this.player1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(115, 25);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Player 1 : X";
            // 
            // endgamePanel
            // 
            this.endgamePanel.BackColor = System.Drawing.Color.Transparent;
            this.endgamePanel.Controls.Add(this.button20);
            this.endgamePanel.Controls.Add(this.button19);
            this.endgamePanel.Controls.Add(this.label1);
            this.endgamePanel.Controls.Add(this.endgameMessageLabel);
            this.endgamePanel.Controls.Add(this.button10);
            this.endgamePanel.Controls.Add(this.button11);
            this.endgamePanel.Controls.Add(this.button12);
            this.endgamePanel.Controls.Add(this.button13);
            this.endgamePanel.Controls.Add(this.button14);
            this.endgamePanel.Controls.Add(this.button15);
            this.endgamePanel.Controls.Add(this.button16);
            this.endgamePanel.Controls.Add(this.button17);
            this.endgamePanel.Controls.Add(this.button18);
            this.endgamePanel.Location = new System.Drawing.Point(3, 4);
            this.endgamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.endgamePanel.Name = "endgamePanel";
            this.endgamePanel.Size = new System.Drawing.Size(814, 494);
            this.endgamePanel.TabIndex = 13;
            this.endgamePanel.Visible = false;
            this.endgamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.endgamePanel_Paint);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Red;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Location = new System.Drawing.Point(440, 306);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(141, 65);
            this.button20.TabIndex = 14;
            this.button20.Text = "NO";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.GreenYellow;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(166, 309);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(141, 65);
            this.button19.TabIndex = 13;
            this.button19.Text = "YES";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Ink Free", 35F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(221, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 73);
            this.label1.TabIndex = 12;
            this.label1.Text = "Play again?";
            // 
            // endgameMessageLabel
            // 
            this.endgameMessageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.endgameMessageLabel.Font = new System.Drawing.Font("Yu Gothic UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endgameMessageLabel.ForeColor = System.Drawing.Color.Ivory;
            this.endgameMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.endgameMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endgameMessageLabel.Name = "endgameMessageLabel";
            this.endgameMessageLabel.Size = new System.Drawing.Size(814, 57);
            this.endgameMessageLabel.TabIndex = 11;
            this.endgameMessageLabel.Text = "Player X Wins! ";
            this.endgameMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.endgameMessageLabel.Click += new System.EventHandler(this.endgameMessageLabel_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(497, 306);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 102);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(329, 306);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 102);
            this.button11.TabIndex = 9;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(175, 306);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(107, 102);
            this.button12.TabIndex = 8;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button13.Location = new System.Drawing.Point(497, 167);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(107, 102);
            this.button13.TabIndex = 7;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button14.Location = new System.Drawing.Point(329, 167);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(107, 102);
            this.button14.TabIndex = 6;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button15.Location = new System.Drawing.Point(175, 167);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(107, 102);
            this.button15.TabIndex = 5;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button16.Location = new System.Drawing.Point(497, 35);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(107, 102);
            this.button16.TabIndex = 4;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button17.Location = new System.Drawing.Point(329, 35);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(107, 102);
            this.button17.TabIndex = 3;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold);
            this.button18.Location = new System.Drawing.Point(175, 35);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(107, 102);
            this.button18.TabIndex = 2;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.tic_tac_toe_g21ef11d3c_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 467);
            this.Controls.Add(this.endgamePanel);
            this.Controls.Add(this.sgamePanel);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.singleButton);
            this.Controls.Add(this.mainMenuLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sgamePanel.ResumeLayout(false);
            this.sgamePanel.PerformLayout();
            this.endgamePanel.ResumeLayout(false);
            this.endgamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        //Tic Tac Toe label on main menu
        private System.Windows.Forms.Label mainMenuLabel;
        //single player button on main menu
        private System.Windows.Forms.Button singleButton;
        //multiplayer button on main menu
        private System.Windows.Forms.Button multiButton;
        //start game panel which is normally invisible but gets triggered when selected
        private System.Windows.Forms.Panel sgamePanel;
        //turn label shows whose turn it is to play
        private System.Windows.Forms.Label turnLabel;
        //button numbers start from top left (1) to bottom right (9)
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        //player 2 label
        private System.Windows.Forms.Label player2Label;
        //player 1 label
        private System.Windows.Forms.Label player1Label;
        //computer player label
        private System.Windows.Forms.Label computerLabel;
        //endgame panel gets triggered only when game ends
        private System.Windows.Forms.Panel endgamePanel;
        //play again? yes and no buttons
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        //play again? label
        private System.Windows.Forms.Label label1;
        //player x wins endgame label
        private System.Windows.Forms.Label endgameMessageLabel;

        //these are just endgame dummy buttons for decoration
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
    }
}

