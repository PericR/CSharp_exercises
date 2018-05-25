using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11IsBitOnPPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: ");
            int bitPosition = int.Parse(Console.ReadLine());

            Console.WriteLine(CheckIfBitIs1(number, bitPosition));
        }

        static bool CheckIfBitIs1(int number, int bitPosition)
        {
            int mask = 1 << bitPosition;
            return (number & mask) != 0;
        }
    }
}
