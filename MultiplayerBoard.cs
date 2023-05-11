using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class MultiplayerBoard
    {
        public string[] board = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string player1 = "P1";
        public string player2 = "P2";
        public int round = 0;

        public Dictionary<string, string> Turn(int element, string player)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (board[element] != "P1" && board[element] != "P2")
            {
                round++;
                board[element] = player;
                if (Winning(board, player))
                {
                    if (player1.Equals(player))
                    {
                        //Player 1 W
                        result["status"] = "P1W";
                        return result;
                    }
                    else
                    {
                        //Player 2 W
                        result["status"] = "P2W";
                        return result;
                    }
                    
                }
                else if (round > 8)
                {
                    //Tie
                    result["status"] = "T";
                    return result;
                }
            }

            //Return null to continue game to next turn
            return null;
        }

        private bool Winning(string[] board, string player)
        {
            if (
                (board[0] == player && board[1] == player && board[2] == player) ||
                (board[3] == player && board[4] == player && board[5] == player) ||
                (board[6] == player && board[7] == player && board[8] == player) ||
                (board[0] == player && board[3] == player && board[6] == player) ||
                (board[1] == player && board[4] == player && board[7] == player) ||
                (board[2] == player && board[5] == player && board[8] == player) ||
                (board[0] == player && board[4] == player && board[8] == player) ||
                (board[2] == player && board[4] == player && board[6] == player)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
