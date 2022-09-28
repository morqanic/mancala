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
    public partial class GameBoard : Form
    {
        string mode = "Classic";
        bool player1turn = true;
        bool makemove = true;
        string dif = "Random";
        Label[] gameBoard = new Label[14];
        public GameBoard(string gamemode, string difficulty)
        {
            InitializeComponent();
            gameRules.Text = gamemode+ " | " + difficulty;
            BoardLoad(gamemode, difficulty);
            mode = gamemode;
            dif = difficulty;//just so I can have a rematch function for afer a win

        }
        private void BoardLoad(string gamemode, string difficulty)
        {
            int i = 0;
            while (i < 14)
            {
                gameBoard[i] = (Label)Controls.Find("label" + (i).ToString(), true)[0]; // creating an array of labels so can be easily editied
                i++;
            }
             
            if (difficulty == "Normal")
            {
                i = 0;
                while (i < 14)
                {
                    gameBoard[i].Text = 4.ToString(); //all holes start with 4 beads
                    i++;
                }
                gameBoard[6].Text = 0.ToString(); //goals start empty
                gameBoard[13].Text = 0.ToString();
            }
            else if (difficulty == "Random")
            {
                i = 0;
                int randomNumber = 1;
                Random rnd = new Random();
                while (i < 6)
                {
                    randomNumber = rnd.Next(1, 5); // so opposing sides have same number and remains fair
                    gameBoard[i].Text = randomNumber.ToString();
                    gameBoard[i+7].Text = randomNumber.ToString();
                    i++;
                }
                gameBoard[6].Text = 0.ToString(); //goals start empty
                gameBoard[13].Text = 0.ToString();
            }
            
        }
        private bool ValidMove(int i)

        {
            if (gameBoard[i].Text != "0") //prevents playing a nullmove
            {
                if (makemove == true) //to stop entering multiple moves at once
                {
                    if (i >= 7 && i <= 12 && player1turn) //to check on right side of board
                    {
                        return true;
                    }
                    else if (i >= 0 && i <= 5 && player1turn == false)//to check on right side of board
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        private void MakeMove(int i)
        {
            makemove = false;
            int total = Convert.ToInt16(gameBoard[i].Text);
            gameBoard[i].Text = 0.ToString(); //as game acts like you picked it up and disperse
            while (total != 0)
            {
                if (i < 13) //moving up one arround the board
                {
                    i++;
                }
                else
                {
                    i = 0; //if 13 can't go any higher, needs to go back to zero
                }
                if (player1turn == true)
                {
                    if (i == 6) //can't land here as other playuers catchment
                    {
                        i++;
                    }
                }
                else if (player1turn == false)
                {
                    if (i == 13) //can't land here as other playuers catchment
                    {
                        i = 0; 
                    }
                }

                gameBoard[i].Text = (Convert.ToInt16(gameBoard[i].Text) + 1).ToString();

                total -= 1;


                if (total == 0 && CheckWin() == false) 
                {
                    if (mode == "Avalanche")
                    {
                        Avalanche(i);
                    }
                    else if (mode == "Capture")
                    {
                        Capturre(i);
                    }

                }
                
            }
            if (CheckWin())
            {
                i = 0;
                while (i < 6)
                {
                    gameBoard[6].Text = (Convert.ToInt16(gameBoard[6].Text) + Convert.ToInt16(gameBoard[i].Text)).ToString();//adding unused ome to respective pile
                    i++;
                }
                i = 7;
                while (i < 13)
                {
                    gameBoard[13].Text = (Convert.ToInt16(gameBoard[13].Text) + Convert.ToInt16(gameBoard[i].Text)).ToString();//adding unused ome to respective pile
                    i++;
                }
                string winner = "Player 1 Won!!!";
                if (Convert.ToInt16(gameBoard[13].Text) > Convert.ToInt16(gameBoard[6].Text))
                {
                    winner = "Player 1 Won!!!";
                }
                else if (Convert.ToInt16(gameBoard[13].Text) == Convert.ToInt16(gameBoard[6].Text))
                {
                    winner = "It was a Tie!!!";
                }
                else
                {
                    winner = "Player 2 Won!!!";
                }
                this.Hide();
                Winner Win = new Winner(winner, mode, dif);
                Win.Show();
            }
            if (i != 6 && i != 13)//these are positions where you get another turn
            {
                if (player1turn)
                {
                    Turn.BackColor = Color.FromName("Gray");
                    player1turn = false;
                }
                else
                {
                    Turn.BackColor = Color.FromArgb(224, 224, 224); //light grey
                    player1turn = true;
                }
            }
            makemove = true;

        }
        private void Avalanche(int i)
        {
            if (Convert.ToInt16(gameBoard[i].Text) > 1 && i != 13 && i != 6) //If in endzone get another move, wouold be awkward if it dispersed all your numbers againa ahaha
            {
                MakeMove(i);
            }
        }
        private void Capturre(int i)
        {
            if (Convert.ToInt16(gameBoard[i].Text) == 1 && i != 13 && i != 6)
            {
                if (player1turn == true)
                {
                    gameBoard[13].Text = (Convert.ToInt16(gameBoard[12-i].Text) + 1 + Convert.ToInt16(gameBoard[13].Text)).ToString(); // as 12-i = direct opposite
                    
                } else if (player1turn == false)
                {
                    gameBoard[6].Text = (Convert.ToInt16(gameBoard[12 - i].Text) + 1 + Convert.ToInt16(gameBoard[6].Text)).ToString();
                }
                gameBoard[i].Text = 0.ToString();//clear the left overs
                gameBoard[12 - i].Text = 0.ToString();
            }
        }
        private bool CheckWin()
        {
            int i = 0;// if either row has no numbers it results in the end of the game
            bool win = true;
            while (i < 6)// check through all one aisle
            {
                if (gameBoard[i].Text != 0.ToString()) 
                {
                    win = false;//if one still there game still goes on
                }
                i++;
            }
            if (win == true)
            {
                return true;
            }

            i = 5;
            win = true;
            while (i < 13) //just the same stuff but checking a different row
            {
                if (gameBoard[i].Text != 0.ToString())
                {
                    win = false;
                }
                i++;
            }
            if (win == true)
            {
                return true;
            }
            return false; //if none are clear
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (ValidMove(0))
            {
                MakeMove(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidMove(1))
            {
                MakeMove(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ValidMove(2))
            {
                MakeMove(2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ValidMove(3))
            {
                MakeMove(3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(ValidMove(4))
            {
                MakeMove(4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(ValidMove(5))
            {
                MakeMove(5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(ValidMove(7))
            {
                MakeMove(7);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(ValidMove(8))
            {
                MakeMove(8);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(ValidMove(9))
            {
                MakeMove(9);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(ValidMove(10))
            {
                MakeMove(10);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(ValidMove(11))
            {
                MakeMove(11);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(ValidMove(12))
            {
                MakeMove(12);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home = new HomePage();
            Home.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Avalanche Mode \n Rules: \n1.Each player has a store on one side of the board. \n2.Players take turns choosing a pile from one of the holes.Moving counter - clockwise, stones from the selected pile are deposited in each of the following hole. \n3.If you drop the last stone into an unempty hole, you will pick up the stones from that hole and continue depositing them counter - clockwise. \n4.Your turn is over when you drop the last stone into an empty hole \n5.If you drop the last stone into your store -you get a free turn. \n6.The game ends when all six holes on either side of the board are empty. \n\nGoal: \nPlayer with most stones in their store wins.\n\n\nCapture Mode\nRules:\n1.Each player has a store on one side of the board.\n2.Players take turns choosing a pile from one of the holes. Moving counter-clockwise, stones from the selected pile are deposited in each of the following hole until you run out of stones.\n3.If you drop the last stone into your store -you get a free turn.\n4.If you drop the last stone into an empty hole on your side of the board - you can capture stones from the hole on the opposite side.\n5.The game ends when all six holes on either side of the board are empty. If a player has any stones on their side of the board when the game ends -he will capture all of those stones.\n\nGoal:\nPlayer with most stones in their store wins."); //rules taken from GamePigeon
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void label0_Click(object sender, EventArgs e)
        {
            if(ValidMove(0))
            {
                MakeMove(0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (ValidMove(1))
            {
                MakeMove(1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (ValidMove(2))
            {
                MakeMove(2);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (ValidMove(3))
            {
                MakeMove(3);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (ValidMove(4))
            {
                MakeMove(4);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (ValidMove(5))
            {
                MakeMove(5);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (ValidMove(7))
            {
                MakeMove(7);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (ValidMove(8))
            {
                MakeMove(8);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (ValidMove(9))
            {
                MakeMove(9);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (ValidMove(10))
            {
                MakeMove(10);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (ValidMove(11))
            {
                MakeMove(11);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (ValidMove(12))
            {
                MakeMove(12);
            }
        }
    }
}
