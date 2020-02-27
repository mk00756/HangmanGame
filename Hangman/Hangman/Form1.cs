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
        private static int lives = 6;
        public randomWord rand = new randomWord();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        public static void SetWord() {
            //Gets the word
            wordToGuse = "";
            //Sets the 
        }

        //Chages the word that is on the screen
        public void InitWordOnScreen() {
            //Sets the charicters in the word to guse
            for (int i = 0; i < wordToGuse.Length; i++) {
                //if the letter is a spce
                if (wordToGuse[i] == ' ') wordOnScreen += ' ';
                //if it is not a space
                else wordOnScreen += '_';
            }
        }

        //Checks if the word is compleat
        public static bool WordIsComplete() { return wordToGuse == wordOnScreen; }

        //Checs the entiyer word
        public static bool CheckWholeWord(string s) {
            //If the word is corect
            if(wordToGuse == s) {
                wordToGuse = s;
                return true;
            }
            //If it is not
            return false;
        }

        //Reyrns if the word contains the letter gused
        public static bool DoesContainWord(char input) {
            //Flag
            bool guseFlaag = false;
            //Tepoery input
            string temp = "";
            //Loops throug the word
            for (int i = 0; i < wordToGuse.Length; i++) {
                //if the letter has not
                if (wordToGuse[i] == input && wordOnScreen[i] != '*') {
                    //Sets the imput and the guse flag
                    temp += input;
                    guseFlaag = true;
                }
                //if it is not the right charicter
                else temp += '*';
            }
            //Sets the word on screen and returns if the word is right
            wordOnScreen = temp;
            return guseFlaag;
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {

        }

        /* Reset the game, pick a new word */
        private void replayBtn_Click(object sender, EventArgs e)
        {
            livesLbl.Text = "" + maxLives;
            hangmanPic.Image = Hangman.Properties.Resources.hangman0;
            wordOnScreen = rand.getWord();
            wordLbl.Text = wordOnScreen;
        }
    }
}
