using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int randomNumber = 0, lives;

        private void btnGuess_Click(object sender, EventArgs e)
        {
            switch (btnGuess.Text)
            {
                case "Guess":
                    int score;
                    if (int.Parse(txtGuess.Text) == randomNumber)
                    {
                        score = lives * 10;
                        lblGuessResult.Text = "You Win!!! \n Your Score is: " + score;
                        btnGuess.Text = "Play Again";
                        txtGuess.Visible = false;
                    }
                    else if (int.Parse(txtGuess.Text) < randomNumber && lives > 1)
                    {
                        lblGuessResult.Text = "Your number is smaller. Current live(s): " + (--lives);
                    }
                    else if (int.Parse(txtGuess.Text) > randomNumber && lives > 1)
                    {
                        lblGuessResult.Text = "Your number is bigger. Current live(s): " + (--lives);
                    }
                    else
                    {
                        lblGuessResult.Text = "You loose the number was: " + randomNumber;
                        btnGuess.Text = "Play Again";
                        txtGuess.Visible = false;
                    }
                    txtGuess.Text = "";
                    break;
                case "Start":
                case "Play Again":
                    randomNumber = 4;
                    lives = 5;
                    txtGuess.Visible = true;
                    btnGuess.Text = "Guess";
                    lblGuessResult.Text = "Game started";
                    break;
                default:
                    break;
            }      

        }

    }
}
