using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class SinglePlayerBoard
    {
        public string[] board = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string huPlayer = "P1";
        public string aiPlayer = "C";
        public int round = 0;

        public Dictionary<string,string> Turn(int element, string player)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (board[element] != "P1" && board[element] != "C")
            {
                round++;
                board[element] = player;
                if (Winning(board, player))
                {
                    //Player 1 Wins
                    result["status"] = "P1W";
                    return result;
                }
                else if (round > 8)
                {
                    //Tie
                    result["status"] = "T";
                    return result;
                }
                else
                {
                    round++;
                    var index = Minmax(board, aiPlayer);
                    board[Convert.ToInt32(index["index"])] = aiPlayer;
                    result["index"] = index["index"];
                    if (Winning(board, aiPlayer))
                    {
                        //Trigger AI wins End Game
                        result["status"] = "AW";
                        return result;
                    }
                    else if (round == 0)
                    {
                        //Trigger Tie End Game
                        result["status"] = "T";
                        return result;
                    }
                    //Return result to continue game to next turn
                    return result;
                }
            }

            //Return null to continue game to next turn
            return null;
        }

        private Dictionary<string, string> Minmax(string[] reboard, string player)
        {
            string[] array = Avail(reboard);
            //Assign score -10 if human is winning
            if (Winning(reboard, this.huPlayer))
            {
                var dict = new Dictionary<string, string>();
                dict["score"] = "-10";
                return dict;
            }
            //Assign score 10 if AI is winning
            else if (Winning(reboard, this.aiPlayer))
            {
                var dict = new Dictionary<string, string>();
                dict["score"] = "10";
                return dict;
            }
            //Assign score 0 if no one is winning and no available moves left
            else if (array.Length == 0)
            {
                var dict = new Dictionary<string, string>();
                dict["score"] = "0";
                return dict;
            }
            //Moves dictionary to contain all the possible moves
            Dictionary<int, dynamic> moves = new Dictionary<int, dynamic>();
            //itterate through and determine moves till no more moves are available
            for (var i = 0; i < array.Length; i++)
            {
                //Move dictionary to contain a single move
                var move = new Dictionary<string, string>
                {
                    ["index"] = reboard[Convert.ToInt32(array[i])]
                };
                reboard[Convert.ToInt32(array[i])] = player;

                //If player is ai call minmax again with human player
                if (player == aiPlayer)
                {
                    var g = Minmax(reboard, huPlayer);
                    //store the score of move
                    move["score"] = g["score"];
                }
                //If player is human call minmax again with ai player
                else
                {
                    var g = Minmax(reboard, aiPlayer);
                    //store the score of move
                    move["score"] = g["score"];
                }
                //set the index of board again
                reboard[Convert.ToInt32(array[i])] = move["index"];
                //store the move
                moves[i] = move;
            }
            //initialize bestMove
            int bestMove = 0;
            //If player is aiPlayer
            if (player == aiPlayer)
            {
                //Set bestScore to -10000
                var bestScore = -10000;
                //for each move
                for (var i = 0; i < moves.Count(); i++)
                {
                    //If the move is higher than best score 
                    if (Convert.ToInt32(moves[i]["score"]) > bestScore)
                    {
                        //set the best score to moves score 
                        bestScore = Convert.ToInt32(moves[i]["score"]);
                        //set current move index as best move
                        bestMove = i;
                    }
                }
            }
            //If player is human
            else
            {
                //Set bestScore to 10000
                var bestScore = 10000;
                var count = moves.Count();
                //for each move
                for (var i = 0; i < count; i++)
                {
                    //If the move is lower than best score 
                    if (Convert.ToInt32(moves[i]["score"]) < bestScore)
                    {
                        //set the best score to moves score 
                        bestScore = Convert.ToInt32(moves[i]["score"]);
                        //set current move index as best move
                        bestMove = i;
                    }
                }
            }
            //return the best move possible
            return moves[bestMove];
        }

        //method to get available moves on board
        private string[] Avail(string[] reboard)
        {
            return reboard.Where(c => c != "P1" && c != "C").ToArray();
        }

        //method to check if a player is winning
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
