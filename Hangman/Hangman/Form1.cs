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

        private static string wordToGuse = "hello";
        private static string wordOnScreen = "";
        private static int maxLives = 10;
        private static int lives = 10;
        public randomWord rand = new randomWord();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        /* Reset the game, pick a new word */
        //H=When the player presses the play button
        private void replayBtn_Click(object sender, EventArgs e) {
            //Initilizes the game
            HangmanGame.SetWord();
            //Sets up the UI
            guessLbl.Text = "";

            livesLbl.Text = "" + maxLives;
            hangmanPic.Image = Hangman.Properties.Resources.hangman0;
            wordOnScreen = rand.getWord();
            wordLbl.Text = wordOnScreen;

            UpdateUI();
        }

        public void UpdateUI() {
            replayBtn.Enabled = false;
            wordLbl.Text = HangmanGame.GetWordToGuse();
            livesLbl.Text = HangmanGame.lives.ToString();
            inputTxt.Text = "";
        }

        private void inputBtn_Click(object sender, EventArgs e) {
            //If the input is valid
            if (inputTxt.Text.Length < 1) return;
            else if (inputTxt.Text[0] == ' ') return;
            //Adds charicter to the list
            if (inputTxt.Text.Length == 1) guessLbl.Text += inputTxt.Text[0];
            //Checs if they got it correct
            bool right = HangmanGame.CheckInput(inputTxt.Text);
            if (right) {

            }
            else {
                HangmanGame.lives--;
            }
            //Updates the UI
            UpdateUI();
        }
    }
}
