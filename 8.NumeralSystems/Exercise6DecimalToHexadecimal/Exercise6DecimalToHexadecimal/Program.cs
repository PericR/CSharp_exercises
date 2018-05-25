using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            long decimalNumber = long.Parse(Console.ReadLine());
            string hexadecimalNumber = "";

            while (decimalNumber > 0)
            {
                string remainder = CalculateRemainder(decimalNumber % 16);
                hexadecimalNumber = remainder + hexadecimalNumber;
                decimalNumber /= 16;
            }

            Console.WriteLine("Hexadecimal: {0}", hexadecimalNumber);
        }

        static string CalculateRemainder(long remainder)
        {
            string strRemainder = "";

            switch (remainder)
            {
                case 10:
                    strRemainder = "A";
                    break;
                case 11:
                    strRemainder = "B";
                    break;

                case 12:
                    strRemainder = "C";
                    break;
                case 13:
                    strRemainder = "D";
                    break;
                case 14:
                    strRemainder = "E";
                    break;
                case 15:
                    strRemainder = "F";
                    break;
                default:
                    strRemainder = remainder.ToString();
                    break;
            }

            return strRemainder;
        }
    }
}
