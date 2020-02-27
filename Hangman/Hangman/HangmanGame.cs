using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {
    public static class HangmanGame {

        public static int lives = 0;
        public static int maxLives = 10;

        private static string wordToGuse = "";
        private static string wordOnScreen = "";

        public static string GetWordToGuse() { return wordToGuse; }
        public static string GetWordOnScree() { return wordOnScreen; }

        public static void SetWordTest(string s, int ml) {
            wordToGuse = s;
            //Sets the test input
            setWordOnScreen();
            //Sets the lives
            maxLives = ml;
            lives = maxLives;
        }

        //Sets the word that the player needs to guse
        public static void SetWord() {
            //Gets the word
            randomWord rand = new randomWord();
            wordToGuse = rand.getWord();
            wordOnScreen = "";
            //Sets the test input
            setWordOnScreen();
            lives = maxLives;
        }

        //Handels input
        public static bool CheckInput(string input) {
            //Whole word
            if (input.Length > 1) return CheckWholeWord(input);
            //Single letter
            else return DoseContainLetter(input[0]);
        }

        //Chages the word that is on the screen
        private static void InitWordOnScreen() {
            //Sets the charicters in the word to guse
            for (int i = 0; i < wordToGuse.Length; i++) {
                //if the letter is a spce
                if (wordToGuse[i] == ' ') wordOnScreen += ' ';
                //if it is not a space
                else wordOnScreen += '_';
            }
        }

        //Sets the word on screen
        private static void setWordOnScreen() {
            for(int i = 0; i < wordToGuse.Length; i++) {
                //Sets the qword to guse
                if (wordToGuse[i] == ' ') wordOnScreen += ' ';
                else wordOnScreen += '_';
            }
        }

        //Checks if the word is compleat
        public static bool WordIsComplete() { return wordToGuse == wordOnScreen; }

        //Checs the entiyer word
        public static bool CheckWholeWord(string s) {
            //If the word is corect
            if (wordToGuse == s) {
                wordOnScreen = s;
                return true;
            }
            //If it is not
            return false;
        }

        //Reyrns if the word contains the letter gused
        public static bool DoseContainLetter(char input) {
            //Flag
            bool guseFlaag = false;
            //Tepoery input
            string temp = "";
            //Loops throug the word
            for (int i = 0; i < wordToGuse.Length; i++) {
                //if the letter has not
                if (wordToGuse[i] == input && wordOnScreen[i] == '_') {
                    //Sets the imput and the guse flag
                    temp += input;
                    guseFlaag = true;
                }
                //if it is not the right charicter
                else if (wordOnScreen[i] == '_') temp += '_';
                else temp += wordOnScreen[i];
            }
            //Sets the word on screen and returns if the word is right
            wordOnScreen = temp;
            return guseFlaag;
        }

    }
}
