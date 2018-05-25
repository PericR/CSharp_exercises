using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSubstringsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();
            Console.Write("Now enter substring: ");
            string substring = Console.ReadLine();

            Console.WriteLine(CountSubstringInString(str, substring));
        }

        static int CountSubstringInString(string str, string substring)
        {
            int counter = -1;
            int index = 0 - substring.Length + 1;
            str = str.ToLower();

            do
            {                
                index = str.IndexOf(substring, index + substring.Length - 1);
                counter++;
            }
            while (index != -1);

            return counter;
        }
    }
}
