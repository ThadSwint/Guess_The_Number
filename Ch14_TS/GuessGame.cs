using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch14_TS
{
    public partial class GuessGame : Form
    {
        // difference and random
        static int diff = 0;
        static int randomnumber;

        public GuessGame()
        {
            InitializeComponent();
        }
        // Upon form load call startNew() 
        private void GuessGame_Load(object sender, EventArgs e)
        {
            startNew();
        }
        // startNew() sets properties and creates new random
        private void startNew()
        {
            Random random = new Random();
            randomnumber = random.Next(1, 1001);
            userInput.Enabled = true;
            highOrLowLabel.Text = "";
            userInput.BackColor = Color.Wheat;
            userInput.Text = "Enter a number";
            userInput.Focus();
        }
        // Upon click
        private void submitButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            // Catch format errors
            try
            {
                int userGuess = int.Parse(userInput.Text);
                // Configure warmer and colder functionality
                if (Math.Abs(randomnumber - userGuess) < diff)
                {
                    userInput.BackColor = Color.Red;
                }
                else
                {
                    userInput.BackColor = Color.LightBlue;
                }
                diff = Math.Abs(randomnumber - userGuess);
                // Configure label functionality
                if (userGuess < randomnumber)
                {
                    highOrLowLabel.Text = "Too Low";
                }
                if (userGuess > randomnumber)
                {
                    highOrLowLabel.Text = "Too High";
                }
                if (userGuess == randomnumber)
                {
                    userInput.BackColor = Color.Green;
                    BackColor = Color.Green;
                    MessageBox.Show("Correct");
                    highOrLowLabel.Text = "Click New button to play again";
                    userInput.Enabled = false;
                    clearButton.Enabled = false;
                    submitButton.Enabled = false;
                }
                // Prohibit out of bounds 
                if (userGuess < 0 || userGuess > 1000)
                {
                    highOrLowLabel.Text = "Incorrect input";
                    BackColor = Color.Crimson;
                    userInput.BackColor = Color.Black;
                }
            }
            // Catch format exception
            catch (FormatException)
            {
                highOrLowLabel.Text = "Must be an integer between 0 and 1000";
                BackColor = Color.Red;
                userInput.BackColor = Color.Black;
            }
        }
            private void clearButton_Click(object sender, EventArgs e)
        {
            userInput.Text = "";
            userInput.Focus();
        }
        // newGame button click calls startNew()
        private void newGame_Click(object sender, EventArgs e)
        {
            startNew();
        }

    }
}
