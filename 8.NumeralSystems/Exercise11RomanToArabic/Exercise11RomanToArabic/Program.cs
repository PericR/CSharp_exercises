using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11RomanToArabic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter roman number: ");
            string romanNumb = Console.ReadLine();
            int arabicNumb = 0;

            for(int i = 0; i < romanNumb.Length; i++)
            {
                int current = ConvertToArabic(romanNumb[i].ToString());
                int next = 0;
                if (i < romanNumb.Length - 1)
                {
                    next = ConvertToArabic(romanNumb[i + 1].ToString());
                }

                if (current >= next)
                {
                    arabicNumb += current;
                }
                else
                {
                    arabicNumb -= current;
                }
            }

            Console.WriteLine("Number in decimal is: {0}", arabicNumb);
        }

        static int ConvertToArabic(string roman)
        {
            int arabic = 0;

            switch (roman)
            {
                case "I":
                    arabic = 1;
                    break;
                case "V":
                    arabic = 5;
                    break;
                case "X":
                    arabic = 10;
                    break;
                case "L":
                    arabic = 50;
                    break;
                case "C":
                    arabic = 100;
                    break;
                case "D":
                    arabic = 500;
                    break;
                case "M":
                    arabic = 1000;
                    break;
            }

            return arabic;
        }
    }
}
