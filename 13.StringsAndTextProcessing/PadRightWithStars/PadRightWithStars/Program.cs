using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadRightWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            text = ComplementWithStars(text);

            Console.WriteLine(text);

        }

        private static string ComplementWithStars(string text)
        {
            if (text.Length > 20)
            {
                throw new FormatException("text must be 20 charachters or shorter.");
            }
            else
            {
                text = text.PadRight(20, '*');
            }

            return text;
        }

        
    }
}
