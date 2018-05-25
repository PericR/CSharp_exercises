using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7HexaToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();
            double decimalNumber = 0;

            for (int i = 0, j = hexadecimalNumber.Length - 1; i <= hexadecimalNumber.Length - 1; i++, j--)
            {
                string currentDigit = hexadecimalNumber[i].ToString();
                int current = ConvertDigitToDecimal(currentDigit);

                decimalNumber = decimalNumber + (current * Math.Pow(16d, j));
            }

            Console.WriteLine("{0} in hexadecimal is {1} in decimal.", hexadecimalNumber, decimalNumber);
        }

        static int ConvertDigitToDecimal(string ch)
        {
            int decimalDigit = 0;

            switch (ch)
            {
                case "A":
                    decimalDigit = 10;
                    break;

                case "B":
                    decimalDigit = 11;
                    break;

                case "C":
                    decimalDigit = 12;
                    break;

                case "D":
                    decimalDigit = 13;
                    break;

                case "E":
                    decimalDigit = 14;
                    break;

                case "F":
                    decimalDigit = 15;
                    break;

                default:
                    decimalDigit = Convert.ToInt32(ch);
                    break;
            }

            return decimalDigit;
        }
    }
}
