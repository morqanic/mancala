using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Majorowrk
{
    public partial class Winner : Form
    {
        string mode = "mode";
        string difficulty = "lol"; //these words really don,t matter, jsut allow for rematch
        public Winner(string winner, string gamemode, string dif)
        {
            InitializeComponent();
            lbl_win.Text = winner;
            mode = gamemode;
            difficulty = dif;
        }

        private void Winner_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameBoard Game = new GameBoard(mode, difficulty);
            Game.Show();
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameMode Mode = new GameMode();
            Mode.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
