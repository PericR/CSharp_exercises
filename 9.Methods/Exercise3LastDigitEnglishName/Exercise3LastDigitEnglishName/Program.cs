using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3LastDigitEnglishName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            PrintLastDigit(number);
        }

        static void PrintLastDigit(int number)
        {
            int digit = number % 10;
            string strDigit = "";

            switch (digit)
            {
                case 0:
                    strDigit = "zerro";
                    break;
                case 1:
                    strDigit = "one";
                    break;

                case 2:
                    strDigit = "two";
                    break;

                case 3:
                    strDigit = "tree";
                    break;

                case 4:
                    strDigit = "four";
                    break;

                case 5:
                    strDigit = "five";
                    break;

                case 6:
                    strDigit = "six";
                    break;

                case 7:
                    strDigit = "seven";
                    break;

                case 8:
                    strDigit = "eight";
                    break;

                case 9:
                    strDigit = "nine";
                    break;

                default:
                    strDigit = "NaN";
                    break;
            }

            Console.WriteLine("Last digit is {0}", strDigit);
        }
    }
}
