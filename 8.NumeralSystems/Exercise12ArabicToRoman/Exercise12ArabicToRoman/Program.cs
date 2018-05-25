using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12ArabicToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            do
            {
                Console.Write("Enter number in range 0-3999: ");
                number = int.Parse(Console.ReadLine());
            }
            while (number < 0 || number >= 4000);

            string roman = "";

            //ones
            int ones = number % 10;
            number /= 10;
            roman = ConvertToRoman(ones, "I", "V", "X");

            //tens
            int tens = number % 10;
            number /= 10;
            roman = ConvertToRoman(tens, "X", "L", "C") + roman;

            //hundreds
            int hundreds = number % 10;
            number /= 10;
            roman = ConvertToRoman(hundreds, "C", "D", "M") + roman;

            //thousands
            int thousands = number % 10;
            number /= 10;
            roman = ConvertToRoman(thousands, "M", "", "") + roman;

            Console.WriteLine("Roman: {0}", roman);
        }

        static string ConvertToRoman(int arabic, string a, string b, string c)
        {
            string roman = "";

            switch (arabic)
            {
                case 1:
                    roman = a;
                    break;

                case 2:
                    roman = a+a;
                    break;

                case 3:
                    roman = a+a+a;
                    break;

                case 4:
                    roman = a+b;
                    break;

                case 5:
                    roman = b;
                    break;

                case 6:
                    roman = b+a;
                    break;

                case 7:
                    roman = b+a+a;
                    break;

                case 8:
                    roman = b+a+a+a;
                    break;

                case 9:
                    roman = a+c;
                    break;
            }

            return roman;
        }
    }
}
