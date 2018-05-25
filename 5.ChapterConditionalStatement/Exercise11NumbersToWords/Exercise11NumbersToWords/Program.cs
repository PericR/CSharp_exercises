using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string strNumber = "";
            bool succesFullParse = false;

            do
            {
                Console.Write("Enter number in range 0-999: ");
                succesFullParse = int.TryParse(Console.ReadLine(), out number);
            }
            while (!succesFullParse || number < 0 || number > 999);
            

            int hundreds = number / 100;
            int tens = number % 100;
            if (tens < 20)
            {
                strNumber = ConvertHundreds(hundreds) + " " + ConvertTenToNinetyn(tens) + ConvertOneToNine(tens);
            }
            else if (tens >= 20)
            {
                strNumber = ConvertHundreds(hundreds) + " " + ConvertTwentyToNinety(tens / 10) + " " + ConvertOneToNine(tens % 10);
            }

            if (number == 0)
            {
                strNumber = "zero";
            }

            Console.WriteLine(strNumber);

        }

        static string ConvertOneToNine(int number)
        {
            string strNumber = "";
            switch (number)
            {
                case 1:
                    strNumber = "one";
                    break;
                case 2:
                    strNumber = "two";
                    break;
                case 3:
                    strNumber = "three";
                    break;
                case 4:
                    strNumber = "four";
                    break;
                case 5:
                    strNumber = "five";
                    break;
                case 6:
                    strNumber = "six";
                    break;
                case 7:
                    strNumber = "seven";
                    break;
                case 8:
                    strNumber = "eight";
                    break;
                case 9:
                    strNumber = "nine";
                    break;
            }

            return strNumber;
        }

        static string ConvertTenToNinetyn(int number)
        {
            string strNumber = "";

            switch (number)
            {
                case 10:
                    strNumber = "ten";
                    break;
                case 11:
                    strNumber = "eleven";
                    break;
                case 12:
                    strNumber = "twelve";
                    break;
                case 13:
                    strNumber = "thirten";
                    break;
                case 14:
                    strNumber = "fourteen";
                    break;
                case 15:
                    strNumber = "fifteen";
                    break;
                case 16:
                    strNumber = "sixteen";
                    break;
                case 17:
                    strNumber = "seventeen";
                    break;
                case 18:
                    strNumber = "eighteen";
                    break;
                case 19:
                    strNumber = "nineteen";
                    break;
            }

            return strNumber;
        }

        static string ConvertTwentyToNinety(int number)
        {
            string strNumber = "";
            switch (number)
            {
                case 2:
                    strNumber = "twenty";
                    break;
                case 3:
                    strNumber = "thirty";
                    break;
                case 4:
                    strNumber = "forty";
                    break;
                case 5:
                    strNumber = "fifty";
                    break;
                case 6:
                    strNumber = "sixty";
                    break;
                case 7:
                    strNumber = "seventy";
                    break;
                case 8:
                    strNumber = "eighty";
                    break;
                case 9:
                    strNumber = "ninety";
                    break;
            }

            return strNumber;
        }

        static string ConvertHundreds(int number)
        {
            string strNumber = "";
            switch (number)
            {
                case 1:
                    strNumber = "one hundred";
                    break;
                case 2:
                    strNumber = "two hundred";
                    break;
                case 3:
                    strNumber = "three hundred";
                    break;
                case 4:
                    strNumber = "four hundred";
                    break;
                case 5:
                    strNumber = "five hundred";
                    break;
                case 6:
                    strNumber = "six hundred";
                    break;
                case 7:
                    strNumber = "seven hundred";
                    break;
                case 8:
                    strNumber = "eight hundred";
                    break;
                case 9:
                    strNumber = "nine hundred";
                    break;
            }

            return strNumber;
        }
    }
}
