using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            long binaryInt = Convert.ToInt64(binary);
            string hexadecimal = "";

            while (binaryInt > 0)
            {
                string current = (binaryInt % 10000).ToString();
                binaryInt /= 10000;
                switch (current.Length)
                {
                    case 1:
                        current = "000" + current;
                        break;
                    case 2:
                        current = "00" + current;
                        break;
                    case 3:
                        current = "0" + current;
                        break;
                }

                hexadecimal = ConvertToHexadecimal(current) + hexadecimal;
            }

            Console.WriteLine("{0} in binary is {1} in hexadecimal.", binary, hexadecimal);
        }

        static string ConvertToHexadecimal(string current)
        {
            string hexaDigit = "";

            switch (current)
            {
                case "0000":
                    hexaDigit = "0";
                    break;

                case "0001":
                    hexaDigit = "1";
                    break;

                case "0010":
                    hexaDigit = "2";
                    break;

                case "0011":
                    hexaDigit = "3";
                    break;

                case "0100":
                    hexaDigit = "4";
                    break;

                case "0101":
                    hexaDigit = "5";
                    break;

                case "0110":
                    hexaDigit = "6";
                    break;

                case "0111":
                    hexaDigit = "7";
                    break;

                case "1000":
                    hexaDigit = "8";
                    break;

                case "1001":
                    hexaDigit = "9";
                    break;

                case "1010":
                    hexaDigit = "A";
                    break;

                case "1011":
                    hexaDigit = "B";
                    break;

                case "1100":
                    hexaDigit = "C";
                    break;

                case "1101":
                    hexaDigit = "D";
                    break;

                case "1110":
                    hexaDigit = "E";
                    break;

                case "1111":
                    hexaDigit = "F";
                    break;
            }

            return hexaDigit;
        }
    }
}
