using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class Form1 : Form
    {
        //Random object to generate random numbers
        Random randomizer = new Random();

        //Integer variables for addition problem
        int addend1, addend2;

        //Integer variables for subtraction problem
        int minuend, subtrahend;

        //Integer variables for multiplication problem
        int multiplicand, multiplier;

        //Integer variables for division problem
        int dividend, divisor;

        //Timer variable to keep track of remaining time.
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        public void StartTheQuiz()
        {
            //Addition Problem setup and rest
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            //Subtraction Problem setup and reset
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            //Multiplication problem setup and reset
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //Divison problem setup and reset
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
            ResetBackColors();
        }

        //Simple function to reset our background colors on the answers to white
        private void ResetBackColors()
        {
            sum.BackColor = Color.White;
            difference.BackColor = Color.White;
            product.BackColor = Color.White;
            quotient.BackColor = Color.White;
        }

        //Check all answers are correct
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // check answers and display message if correct
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's Up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                timeLabel.BackColor = Color.Transparent;
            }


        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the NumericUpDown Control
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }


        //Added sounds for when you get the right answer for each to be a hint as well as change the color to green for correct answer
        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            { 
                SystemSounds.Exclamation.Play();
                sum.BackColor = Color.Green;
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if (minuend - subtrahend == difference.Value)
            {
                SystemSounds.Exclamation.Play();
                difference.BackColor = Color.Green;
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                SystemSounds.Exclamation.Play();
                product.BackColor = Color.Green;
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (dividend != 0 && divisor != 0 && dividend / divisor == quotient.Value)
            {
                SystemSounds.Exclamation.Play();
                quotient.BackColor = Color.Green;
            }
        }
    }
}
