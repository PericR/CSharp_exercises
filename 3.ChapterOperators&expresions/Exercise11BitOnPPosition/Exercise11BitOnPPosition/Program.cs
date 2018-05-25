using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11BitOnPPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: ");
            int bitPosition = int.Parse(Console.ReadLine());
            int mask = 1 << bitPosition;

            Console.WriteLine((number & mask) != 0 ? "Bit is 1" : "Bit is 0");
        }
    }
}
