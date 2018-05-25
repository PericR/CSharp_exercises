using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = "";

            do
            {
                hexadecimal = ConvertToHex(number) + hexadecimal;
                number /= 16;
            }
            while (number > 0);

            Console.WriteLine(hexadecimal);
        }

        static char ConvertToHex(int number)
        {
            char ch;
            int remainder = number % 16;

            switch (remainder)
            {
                case 0:
                    ch = '0';
                    break;

                case 1:
                    ch = '1';
                    break;

                case 2:
                    ch = '2';
                    break;

                case 3:
                    ch = '3';
                    break;

                case 4:
                    ch = '4';
                    break;

                case 5:
                    ch = '5';
                    break;

                case 6:
                    ch = '6';
                    break;

                case 7:
                    ch = '7';
                    break;

                case 8:
                    ch = '8';
                    break;

                case 9:
                    ch = '9';
                    break;

                case 10:
                    ch = 'A';
                    break;

                case 11:
                    ch = 'B';
                    break;

                case 12:
                    ch = 'C';
                    break;

                case 13:
                    ch = 'D';
                    break;

                case 14:
                    ch = 'E';
                    break;

                case 15:
                    ch = 'F';
                    break;

                default:
                    ch = '*';
                    break;
            }

            return ch;
        }
    }
}
