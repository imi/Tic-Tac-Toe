using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Label[,] board;
        public bool player_turn = true;
        public bool lost = false;
        public int comp_wins = 0, player_wins = 0, tie = 0;

        public Form1()
        {
            InitializeComponent();
            board = new Label[3, 3] {
                {label5, label6, label7},
                {label8, label9, label10},
                {label11, label12, label13}
            };
        }

        public void ai_move()
        {
            string[,] sboard = Minimax.CreateString(board);
            Minimax.minimax(sboard, 20, false, true);
            Label label = board[Minimax.next_pos[0], Minimax.next_pos[1]];
            label.Text = "O";
            get_lose();
            if (!lost) player_turn = true;
        }

        public void get_lose() {
            string[,] sboard = Minimax.CreateString(board);
            int result = Minimax.Winner(sboard);
            if (result != 1)
            {
                lost = true;
                if (result == -2)
                {
                    MessageBox.Show("You Lost Onii-Chan");
                    comp_wins += 1;
                    label20.Text = comp_wins.ToString();
                }
                if (result == 2){
                    MessageBox.Show("You Won Onii-Chan");
                    player_wins += 1;
                    label19.Text = player_wins.ToString();
                }
                if (result == 0) {
                    MessageBox.Show("Tie Onii-Chan");
                    tie += 1;
                    label22.Text = tie.ToString();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (player_turn) {
                if (label5.Text.Length == 0)
                {
                    label5.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label6.Text.Length == 0)
                {
                    label6.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label7.Text.Length == 0)
                {
                    label7.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label8.Text.Length == 0)
                {
                    label8.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label9.Text.Length == 0)
                {
                    label9.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label10.Text.Length == 0)
                {
                    label10.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label11.Text.Length == 0)
                {
                    label11.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label12.Text.Length == 0)
                {
                    label12.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (label13.Text.Length == 0)
                {
                    label13.Text = "X";
                    get_lose();
                    if (!lost) { player_turn = false; ai_move(); };
                }
                else MessageBox.Show("Place is Not Empty");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Label label = board[i, j];
                    label.Text = "";
                    player_turn = true;
                    lost = false;
                }
            }
        }
    }
}
