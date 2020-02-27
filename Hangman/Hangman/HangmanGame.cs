using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {
    public static class HangmanGame {

        private static string wordToGuse = "";
        private static string wordOnScreen = "";
        private static int maxLives = 6;
        private static int lives = 6;

        public static void SetWord() {
            //Gets the word
            wordToGuse = "";
            //This is a test
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

        //Checks if the word is compleat
        public static bool WordIsComplete() { return wordToGuse == wordOnScreen; }

        //Checs the entiyer word
        public static bool CheckWholeWord(string s) {
            //If the word is corect
            if (wordToGuse == s) {
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

    }
}
