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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameMode Mode = new GameMode(); //opens new form
            Mode.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //long rules
            MessageBox.Show("Avalanche Mode \n Rules: \n1.Each player has a store on one side of the board. \n2.Players take turns choosing a pile from one of the holes.Moving counter - clockwise, stones from the selected pile are deposited in each of the following hole. \n3.If you drop the last stone into an unempty hole, you will pick up the stones from that hole and continue depositing them counter - clockwise. \n4.Your turn is over when you drop the last stone into an empty hole \n5.If you drop the last stone into your store -you get a free turn. \n6.The game ends when all six holes on either side of the board are empty. \n\nGoal: \nPlayer with most stones in their store wins.\n\n\nCapture Mode\nRules:\n1.Each player has a store on one side of the board.\n2.Players take turns choosing a pile from one of the holes. Moving counter-clockwise, stones from the selected pile are deposited in each of the following hole until you run out of stones.\n3.If you drop the last stone into your store -you get a free turn.\n4.If you drop the last stone into an empty hole on your side of the board - you can capture stones from the hole on the opposite side.\n5.The game ends when all six holes on either side of the board are empty. If a player has any stones on their side of the board when the game ends -he will capture all of those stones.\n\nGoal:\nPlayer with most stones in their store wins."); //rules taken from GamePigeon
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
