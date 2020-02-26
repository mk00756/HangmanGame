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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        public void InitWordOnScreen() {
            //Sets the charicters in the word to guse
            for (int i = 0; i < wordOnScreen.Length; i++) wordOnScreen += '_';
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
            //Sets the guse flag
            wordOnScreen = temp;
            return guseFlaag;
        }

    }
}
