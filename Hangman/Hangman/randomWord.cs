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

    }


    public void parseData(ArrayList listofWords)
    {

        try
        {
            using (StreamReader sr = new StreamReader("TextFile1.txt"))
            {
                string word = "";

                while ((word = sr.ReadLine()) != null)
                {
                    Console.WriteLine(word);
                    listofWords.Add(word);
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }

}
