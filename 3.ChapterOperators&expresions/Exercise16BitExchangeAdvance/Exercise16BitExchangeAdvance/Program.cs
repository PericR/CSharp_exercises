using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16BitExchangeAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter starting bit: ");
            int startingBit = int.Parse(Console.ReadLine());
            Console.Write("Enter second starting bit: ");
            int secondStartingBit = int.Parse(Console.ReadLine());
            Console.Write("Enter number of bits to change: ");
            int bitNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(ExchangeBits(number, startingBit, secondStartingBit, bitNumber));
        }

        static int ExchangeBits(int number,int start, int secondStart, int bitNumber)
        {
            int bitA = start;
            int bitB = secondStart;

            for (int i = 0; i < bitNumber; i++)
            {
                int firstBit = (number >> bitA) & 1;
                int secondBit = (number >> bitB) & 1;
                number = number & (~(1 << bitB)) | (firstBit << bitB);
                number = number & (~(1 << bitA)) | (secondBit << bitA);

                bitA++;
                bitB++;
            }

            return number;
        }
    }
}
