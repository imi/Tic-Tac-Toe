using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Minimax
    {
        public static List<int> next_pos;
        public static int minimax(string[,] board, int depth, bool max, bool turn = false) {
            int result = Winner(board);
            if (depth == 0 || result != 1) {  return result; }
            if (max)
            {
                int value = -10;
                foreach (List<int> list in emptySpaces(board))
                {
                    board[list[0], list[1]] = "X";
                    int new_value = minimax(board, depth - 1, false);
                    board[list[0], list[1]] = "";
                    if (new_value > value)
                    {
                        value = new_value;
                    };
                }
                return value;
            }
            else
            {
                int value = 10;
                foreach (List<int> list in emptySpaces(board))
                {
                    board[list[0], list[1]] = "O";
                    int new_value = minimax(board, depth - 1, true);
                    board[list[0], list[1]] = "";
                    if (new_value < value)
                    {
                        value = new_value;
                        if (turn) next_pos = list;
                    };
                }
                return value;
            }
        }

        public static int Winner(string[,] board) {
            // Rows
            for (int i = 0; i < 3; i++) {
                if (board[i, 0] == "X" && board[i, 1] == "X" && board[i, 2] == "X") return 2;
                else if (board[i, 0] == "O" && board[i, 1] == "O" && board[i, 2] == "O") return -2;
            }
            // Columns
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == "X" && board[1, i] == "X" && board[2, i] == "X") return 2;
                else if (board[0, i] == "O" && board[1, i] == "O" && board[2, i] == "O") return -2;
            }
            // Dims
            if (board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X") return 2;
            else if (board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O") return -2;
            if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X") return 2;
            else if (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O") return -2;
            // Tie
            bool tie = true;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    string pos = board[i, j];
                    if (pos.Length == 0) tie = false;
                }
            }
            if (tie) return 0;
            return 1;
        }

        public static List<List<int>> emptySpaces(string[,] board) {
            List<List<int>> position = new List<List<int>>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    String elm = board[i,j];
                    if (elm.Length == 0) position.Add(new List<int>() { i, j });
                }
            }
            return position;
        }

        public static string[,] CreateString(Label[,] board){
            string[,] StringBoard = new string[3, 3];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Label label = board[i,j];
                    StringBoard[i, j] = label.Text;
                }
            }
            return StringBoard;
        }
    }
}
