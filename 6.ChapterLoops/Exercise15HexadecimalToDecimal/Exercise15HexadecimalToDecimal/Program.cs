using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string hexadecimal = Console.ReadLine();
            char ch;
            int dec = 0;

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                dec *= 16;
                dec += ConvertHexToDecimal(hexadecimal[i]);
            }

            Console.WriteLine(dec);
        }

        static int ConvertHexToDecimal(char ch)
        {
            int n = 0;

            switch (ch)
            {
                case '0':
                    n = 0;
                    break;

                case '1':
                    n = 1;
                    break;

                case '2':
                    n = 2;
                    break;

                case '3':
                    n = 3;
                    break;

                case '4':
                    n = 4;
                    break;

                case '5':
                    n = 5;
                    break;

                case '6':
                    n = 6;
                    break;

                case '7':
                    n = 7;
                    break;

                case '8':
                    n = 8;
                    break;

                case '9':
                    n = 9;
                    break;

                case 'A':
                    n = 10;
                    break;

                case 'B':
                    n = 11;
                    break;

                case 'C':
                    n = 12;
                    break;

                case 'D':
                    n = 13;
                    break;

                case 'E':
                    n = 14;
                    break;

                case 'F':
                    n = 15;
                    break;

                default:
                    Console.WriteLine("One character is not a number");
                    break;
            }

            return n;
        }
    }
}
