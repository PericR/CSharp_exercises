using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(ExchangeBits(number));
        }

        static int ExchangeBits(int number)
        {
            int bitA = 3;
            int bitB = 24;

            for (int i = 0; i < 3; i++)
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
