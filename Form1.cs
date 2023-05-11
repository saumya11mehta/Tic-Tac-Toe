using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
   
    public partial class Form1 : Form
    {
        public String player = "1";
        public String defaultPlayer = "1";
        public String defaultPlayersSymbol = "X";
        public String vsPlayersSymbol = "O";
        public String player1TurnText = "Player 1 turn";
        public String player2TurnText;
        public Boolean winner = false;
        public Boolean singlePlayer;
        //public SinglePlayerBoard sb1 = new SinglePlayerBoard();
        public SinglePlayerBoard sb1 = null;
        private int buttonPosition;
        public MultiplayerBoard multiplayerBoard = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainMenuLabel_Click(object sender, EventArgs e)
        {

        }

        private void singleButton_Click(object sender, EventArgs e)
        {
            sb1 = new SinglePlayerBoard();
            this.singlePlayer = true;
            clearBoard();
            setSinglePlayerOptions();
        }
        //Set all the required options/settings for single player
        private void setSinglePlayerOptions()
        {
            player = "1";
            defaultPlayer = "1";
            defaultPlayersSymbol = "X";
            vsPlayersSymbol = "O";
            turnLabel.Text = player1TurnText = "Player 1 turn";
            this.player2TurnText = "Your turn player: AI";
            player2Label.Visible = false;
            computerLabel.Visible = true;
            winner = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            this.singlePlayer = false;
            clearBoard();
            setMultiPlayerOptions();
            multiplayerBoard = new MultiplayerBoard();
        }
        //Set all the required options/settings for single player
        private void setMultiPlayerOptions()
        {
            player = "1";
            defaultPlayer = "1";
            defaultPlayersSymbol = "X";
            vsPlayersSymbol = "O";
            turnLabel.Text = player1TurnText = "Player 1 turn";
            this.player2TurnText = "Player 2 turn";
            computerLabel.Visible = false;
            player2Label.Visible = true;
            winner = false;
        }

        //button click events start here 1 to 9
        private void button1_Click(object sender, EventArgs e)
        {
            buttonPosition = 0;
            renderBoardOnClick(button1,buttonPosition);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonPosition = 1;
            renderBoardOnClick(button2,buttonPosition);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonPosition = 2;
            renderBoardOnClick(button3,buttonPosition);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonPosition = 3;
            renderBoardOnClick(button4,buttonPosition);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonPosition = 4;
            renderBoardOnClick(button5,buttonPosition);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonPosition = 5;
            renderBoardOnClick(button6,buttonPosition);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonPosition = 6;
            renderBoardOnClick(button7,buttonPosition);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonPosition = 7;
            renderBoardOnClick(button8,buttonPosition);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonPosition = 8;
            renderBoardOnClick(button9,buttonPosition);
        }// ------   end of button click events    -----

        //player wants replay by clicking yes button
        private void button19_Click(object sender, EventArgs e)
        {
            
            endgamePanel.Visible = false;
        }
        //player doesnt want replay and clicks no button
        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //if there is a winner, endgame panel gets triggered and game panel is hidden
        private void triggerEndgame(string resultStatus)
        {
            if (winner == true)
            {
                sgamePanel.Visible = false;
                switch (resultStatus)
                {
                    case "P1W":
                        endgameMessageLabel.Text = "Player 1 Wins !!!";
                        break;
                    case "P2W":
                        endgameMessageLabel.Text = "Player 2 Wins !!!";
                        break;
                    case "AW":
                        endgameMessageLabel.Text = "Computer Wins !!!";
                        break;
                    case "T":
                        endgameMessageLabel.Text = "The Match is a Draw!";
                        break;
                    default:
                        // code block
                        break;
                }
                //Setting the endgame panel buttons to that of game board
                button10.Text = button9.Text;
                button10.ForeColor = button9.ForeColor;

                button11.Text = button8.Text;
                button11.ForeColor = button8.ForeColor;

                button12.Text = button7.Text;
                button12.ForeColor = button7.ForeColor;
                
                button13.Text = button6.Text;
                button13.ForeColor = button6.ForeColor;
                
                button14.Text = button5.Text;
                button14.ForeColor = button5.ForeColor;
                
                button15.Text = button4.Text;
                button15.ForeColor = button4.ForeColor;
                
                button16.Text = button3.Text;
                button16.ForeColor = button3.ForeColor;
                
                button17.Text = button2.Text;
                button17.ForeColor = button2.ForeColor;

                button18.Text = button1.Text;
                button18.ForeColor = button1.ForeColor;

                endgamePanel.Visible = true;
            }
        }

        //method to clearBord and make game panel visible
        private void clearBoard()
        {
            sgamePanel.Visible = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        //method to Render Board changes on players click
        private void renderBoardOnClick(Button button, int buttonPosition)
        {
            if (button.Text == "")
            {
                button.Text = player == defaultPlayer ? defaultPlayersSymbol : vsPlayersSymbol;
                button.ForeColor = player == defaultPlayer ? Color.Red : Color.Yellow;
                turnLabel.Text = player == defaultPlayer ? player2TurnText : player1TurnText;
                player = player == defaultPlayer ? "2" : "1";
                if (singlePlayer == true)
                {
                    var singlePlayer = player == defaultPlayer ? "C" : "P1";
                    //if single player call turn method
                    var turnResult = sb1.Turn(buttonPosition, singlePlayer);
                    if(turnResult != null)
                    {
                        if (turnResult.ContainsKey("index"))
                        {
                            //if ai player's turn trigger click by ai
                            if (player == "2")
                            {
                                triggerAIClick(turnResult["index"]);
                            }
                        }
                        this.checkStatus(turnResult);
                    }
                    
                }
                else
                {
                    var multplayer = player == defaultPlayer ? "P2" : "P1";
                    var turnResult = multiplayerBoard.Turn(buttonPosition, multplayer);
                    if (turnResult != null)
                    {
                        this.checkStatus(turnResult);
                    }
                }
                
                
            };
        }
        //Check status of the game
        private void checkStatus(Dictionary<string, string> turnResult)
        {
            if (turnResult.ContainsKey("status"))
            {
                winner = true;
                this.triggerEndgame(turnResult["status"]);
            }
        }

        //method to trigger the click from AI's end
        private void triggerAIClick(string boardIndex)
        {
            switch (boardIndex)
            {
                case "0":
                    // code block
                    button1.PerformClick();
                    break;
                case "1":
                    // code block
                    button2.PerformClick();
                    break;
                case "2":
                    // code block
                    button3.PerformClick();
                    break;
                case "3":
                    // code block
                    button4.PerformClick();
                    break;
                case "4":
                    // code block
                    button5.PerformClick();
                    break;
                case "5":
                    // code block
                    button6.PerformClick();
                    break;
                case "6":
                    // code block
                    button7.PerformClick();
                    break;
                case "7":
                    // code block
                    button8.PerformClick();
                    break;
                case "8":
                    // code block
                    button9.PerformClick();
                    break;
                default:
                    // code block
                    break;
            }
        }

        private void endgameMessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void endgamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
