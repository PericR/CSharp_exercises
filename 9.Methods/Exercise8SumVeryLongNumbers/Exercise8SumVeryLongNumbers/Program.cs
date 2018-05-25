using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8SumVeryLongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter firts number: ");
            string first = "";
            first = Console.ReadLine();
            int[] firstNumber = FillNumberInArray(first);

            Console.Write("Enter seccond number: ");
            string seccond = "";
            seccond = Console.ReadLine();
            int[] seccondNumber = FillNumberInArray(seccond);

            int[] result = SumLargeNumbers(firstNumber, seccondNumber);
        }

        static int[] FillNumberInArrayTest()
        {
            int[] number = new int[10000];
            Random rand = new Random();

            for(int i = 0; i < 10000; i++)
            {
                number[i] = rand.Next(0, 10);
            }

            return number;
        }

        static int[] FillNumberInArray(string numb)
        {
            int[] number = new int[10000];

            for (int i = numb.Length - 1, j = 0; i >= 0; i--, j++)
            {
                char digit = numb[i];
                number[j] = int.Parse(digit.ToString());
            }

            return number;
        }

        static int[] SumLargeNumbers(int[] firstNumber, int[] seccondNumber)
        {
            int[] result = new int[10001];
            int surplus = 0;

            result[0] = (firstNumber[0] + seccondNumber[0]) % 10;

            for (int i = 1; i < 10000; i++)
            {
                surplus = (firstNumber[i - 1] + seccondNumber[i - 1]) / 10;
                result[i] = (firstNumber[i] + seccondNumber[i] + surplus) % 10;
                surplus = 0;
            }

            result[10000] = ((firstNumber[9999] + seccondNumber[9999]) / 10);

            return result;
        }
    }
}
