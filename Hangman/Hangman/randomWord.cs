using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman
{
    public class randomWord
    {
        public String wordChoice { get; set; }
        public int maxWords { get; set; }


        public string getWord()
        {

            // Get a random number between 0 and max string
            string word = "";
            Random rand = new Random();

            // Fill out arraylist from textfile
            ArrayList al = parseData();
            word = al[rand.Next(0, maxWords)].ToString();       
                 
            return word;
        }

        

        private ArrayList parseData()
        {
            int counter = 0;

            // Create new arraylist to hold parsed data
            ArrayList listofWords = new ArrayList();
            try
            {
                using (StreamReader sr = new StreamReader("TextFile1.txt"))
                {
                    string word = "";

                    while ((word = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(word);
                        listofWords.Add(word);
                        counter++;
                        
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            maxWords = counter;
            return listofWords;

        }

    }
}
