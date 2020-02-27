using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman;

namespace HangmanTest
{
    [TestClass]
    public class Form1Test
    {
        [TestMethod]
        public void TestSetWord()
        {
            //run set word
            //check if word to guess is not null or empty
        }

        [DataRow ("hello", "_____")]
        [DataRow ("player", "______")]
        [DataRow ("hello player", "_____ ______")]
        [DataRow ("Hello Player", "_____ ______")]
        [DataRow ("Hello,Player", "____________")]
        [DataTestMethod]
        public void TestInitWordOnScreen(string wordToGuess, string expResult)
        {
            //Hangman.Form1.SetWord();
            //Form1 testForm = new Form1();
            //testForm.Setword();
        }

        [DataRow ("hello", "hello", true)]
        [DataRow("hello", "goodbye", false)]
        [DataTestMethod]
        public void TestWordIsComplete(string wordToGuess, string wordOnScreen, bool expResult)
        {
            //set wordToGuse to wordToGuess
            //set wordOnScreen to wordOnScreen
            //run wordIsComplete
            Assert.AreEqual(true, true);
        }
    }
}
