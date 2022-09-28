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
    public partial class GameMode : Form
    {
        public GameMode()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            int answered = 0; //check radio buttons have input
            string gamemode = "Capture";
            string difficulty = "Normal";
            if (Capture.Checked)
            {
                answered += 1;
                gamemode = "Capture";
            }else if (Avalanche.Checked)
            {
                answered += 1;
                gamemode = "Avalanche";
            }
            if (Normal.Checked)
            {
                answered += 1;
                difficulty = "Normal";
            }
            else if (Random.Checked)
            {
                answered += 1;
                difficulty = "Random";
            }

            if (answered == 2)
            {
                this.Hide();
                GameBoard Game = new GameBoard(gamemode, difficulty);
                Game.Show();
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home = new HomePage();
            Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
