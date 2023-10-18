using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int chances = 3, enteredNumber, randomNumber;

        private void button3_Click(object sender, EventArgs e)
        {
            Size = new Size(366, 305);
            randomNumber = rnd.Next(1, 10);
            button3.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(12, 59);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chances = 3;
            bilgiLabel.Text = "";
            bilgiLabel.ForeColor = Color.Black;
            label4.Text = "Remaining chances: " + (chances);
            textBox1.Clear();
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Visible = false;
            randomNumber = rnd.Next(1,10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(366, 131);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enteredNumber = Convert.ToInt32(textBox1.Text);
            if(enteredNumber == randomNumber) 
            {
                bilgiLabel.Text = "Congratulations, correct guess!";
                bilgiLabel.ForeColor = Color.Green;
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Visible = true;
            }
            else if(enteredNumber < randomNumber && chances > 1)
            {
                bilgiLabel.Text = "The number I guessed is higher!";
            }
            else if(enteredNumber > randomNumber && chances > 1)
            {
                bilgiLabel.Text = "The number I guessed is smaller!";
            }
            else
            {
                bilgiLabel.Text = "You've run out of guesses!";
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Visible = true;
            }
            chances--;
            label4.Text = "Remaining chances: " + (chances);
            
        }
    }
}
