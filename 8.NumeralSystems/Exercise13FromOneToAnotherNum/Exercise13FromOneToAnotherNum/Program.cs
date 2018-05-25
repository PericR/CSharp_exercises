using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13FromOneToAnotherNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N,S,D (2 ≤ S, D ≤ 16)");

            Console.Write("Enter N: ");
            string number = Console.ReadLine();

            Console.Write("Enter S: ");
            int smaller = int.Parse(Console.ReadLine());

            Console.Write("Enter D: ");
            int bigger = int.Parse(Console.ReadLine());

            double decimalNumber = 0;

            for (int i = 0, j = number.Length - 1; i <= number.Length - 1; i++, j--)
            {
                string currentDigit = number[i].ToString();
                int current = ConvertDigitToDecimal(currentDigit);

                decimalNumber = decimalNumber + (current * Math.Pow(smaller, j));
            }

            Console.WriteLine("{0} in S based system is {1} in decimal.", number, decimalNumber);

            string DBasedSystem = "";

            int decimalNumb = (int)decimalNumber;

            while (decimalNumb > 0)
            {
                string remainder = CalculateRemainder(decimalNumb % bigger);
                DBasedSystem = remainder + DBasedSystem;
                decimalNumb /= 16;
            }

            Console.WriteLine("D Based System: {0}", DBasedSystem);
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

        static string CalculateRemainder(int remainder)
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
