using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Your string reversed: {0}", ReverseString(str));
        }

        static string ReverseString(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }

            return reversed.ToString();
        }
    }
}
