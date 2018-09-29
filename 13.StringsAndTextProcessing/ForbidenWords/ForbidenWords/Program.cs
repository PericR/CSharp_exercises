using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbidenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            string forbidenWords = "C#,CLR,Microsoft";

            Console.WriteLine(text);
            text = CenzorForbidenWords(text, forbidenWords);
            Console.WriteLine(text);
        }

        static string CenzorForbidenWords(string text, string forbidenWords)
        {
            string[] forbidenWordsArray = forbidenWords.Split(',');

            foreach (string forbidenWord in forbidenWordsArray)
            {
                        text = text.Replace(forbidenWord, new string('#', forbidenWord.Length));
            }

            return text;
        }
    }
}
