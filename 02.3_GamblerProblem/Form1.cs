using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._3_GamblerProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //A gambler has a choice of two games. The first costs $8.00 to play. 
        //Two dice are rolled and the player receive the sum
        //of the numbers rolled in dollars.The second game costs $15.00 to play.
        //Two dice are rolled and the player receives the product of the numbers rolled in dollars.

        //Write a program which simulates each game being played 1000 times 
        //and calculates the average winnings per game. Also determine which game the gambler should choose. 

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            LstView.Clear();

            int game1 = 0;
            int game2 = 0;
            int averageGame1 = 0;
            int averageGame2 = 0;

            for(int i = 0; i < 1000; i++)
            {
                Random r = new Random();

                //game 1
                int dice1 = r.Next(1, 7);
                int dice2 = r.Next(1, 7);
                game1 += dice1 + dice2 - 8;

                //game 2
                int dice3 = r.Next(1, 7);
                int dice4 = r.Next(1, 7);
                game2 += dice3 * dice4 - 15;
            }
            averageGame1 = game1 / 1000;
            averageGame2 = game2 / 1000;

            LstView.Items.Add("Average Game1 = " + averageGame1.ToString());
            LstView.Items.Add("Average Game2 = " + averageGame2.ToString());


            if (averageGame1 <= 0 && averageGame2 <= 0)
            {
                LstView.Items.Add("Better stop gambling");
            }
            else if (averageGame1 > averageGame2)
            {
                LstView.Items.Add("Game 1 offers more profit");
            }else if(averageGame1 < averageGame2)
            {
                LstView.Items.Add("Game 2 offers more profit");
            }
            else
            {
                LstView.Items.Add("Both games offer same profit");
            }
        }
    }
}
