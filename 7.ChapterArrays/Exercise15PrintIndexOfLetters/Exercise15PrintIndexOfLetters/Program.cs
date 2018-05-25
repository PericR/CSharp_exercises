using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15PrintIndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[58];
            for (int i = 0, j = 65; i < 58; i++, j++)
            {
                letters[i] = (char)j;
            }

            Console.Write("Enter your word: ");
            string word = Console.ReadLine();

            foreach(char ch in word)
            {
                Console.WriteLine((int)ch - (int)'A');
            }
        }
    }
}
