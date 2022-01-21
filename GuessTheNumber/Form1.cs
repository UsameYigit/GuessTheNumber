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

        int randomNumber;

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            if(int.Parse(txtGuess.Text) == randomNumber)
            {
                lblGuessResult.Text = "You Win!!!";
            }
            else
            {
                lblGuessResult.Text = "Looser!!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = rnd.Next(1, 101);
        }
    }
}
