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
            string word = "";
            Random rand = new Random();

            ArrayList al = parseData();

            word = al[rand.Next(0, maxWords)];            
            return word;
        }

        

        private ArrayList parseData()
        {
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
