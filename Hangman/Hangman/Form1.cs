using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public randomWord rand = new randomWord();

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                inputBtn.PerformClick();
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.inputTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);

        }

        private void Form1_Load(object sender, EventArgs e) {
            //disables the input for the game
            inputBtn.Enabled = false;
            //Enables the replay button
            replayBtn.Enabled = true;
        }

        /* Reset the game, pick a new word */
        //H=When the player presses the play button
        private void replayBtn_Click(object sender, EventArgs e) {
            //Initilizes the game
            HangmanGame.SetWord();
            //Sets up the UI
            guessLbl.Text = "";
            //disables the input for the game
            inputBtn.Enabled = true;
            replayBtn.Enabled = false;
            hangmanPic.Image = Hangman.Properties.Resources.hangman0;
            UpdateUI();
        }

        public void UpdateUI() {
            wordLbl.Text = HangmanGame.GetWordOnScree();
            livesLbl.Text = HangmanGame.lives.ToString();
            inputTxt.Text = "";
        }

        private void inputBtn_Click(object sender, EventArgs e) {
            //Gets the text and sets it to lower case
            string input = inputTxt.Text.ToLower();
            //If the input is valid
            if (input.Length < 1) return;
            else if (input[0] == ' ') return;
            //Adds charicter to the list
            if (guessLbl.Text != "") guessLbl.Text += ", ";
            if (input.Length == 1) guessLbl.Text += input[0];
            //Checs if they got it correct
            bool right = HangmanGame.CheckInput(input);
            if (right) {
                //if they have cmpleted the word
                if(HangmanGame.WordIsComplete()) {
                    //disables the input for the game
                    inputBtn.Enabled = false;
                    //Enables the replay button
                    replayBtn.Enabled = true;
                    inputTxt.Text = "";
                    MessageBox.Show("Game over! You won!");
                }
            }
            else {
                HangmanGame.lives--;
                switch (HangmanGame.lives){
                    case 0:
                        hangmanPic.Image = Hangman.Properties.Resources.hangmanFinal;
                        break;
                    case 1:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman9;
                        break;
                    case 2:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman8;
                        break;
                    case 3:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman7;
                        break;
                    case 4:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman6;
                        break;
                    case 5:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman5;
                        break;
                    case 6:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman4;
                        break;
                    case 7:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman3;
                        break;
                    case 8:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman2;
                        break;
                    case 9:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman1;
                        break;
                    default:
                        hangmanPic.Image = Hangman.Properties.Resources.hangman0;
                        break;
                }
                //If they are out of lives
                if(HangmanGame.lives <= 0) {
                    //disables the input for the game
                    inputBtn.Enabled = false;
                    //Enables the replay button
                    replayBtn.Enabled = true;
                    inputTxt.Text = ""; 
                }
            }
            //Updates the UI
            UpdateUI();

            if (HangmanGame.lives <= 0)
            {
                MessageBox.Show("Game over! You lost!");
                replayBtn.Enabled = true;
            }
        }
    }
}
