using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsAndExplanationsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrys = ".NET – platform for applications from Microsoft\n CLR – managed execution environment for .NET\n namespace – hierarchical organization of classes";

            WordDictionary dictionary = new WordDictionary();
            dictionary.AcceptNewEntrys(entrys);

            while (true)
            {
                string word = Console.ReadLine();
                word = word.ToLower();
                if (word == "exit")
                {
                    break;
                }
                Console.WriteLine(dictionary.CheckGivenWord(word));
            }
        }
    }
}
