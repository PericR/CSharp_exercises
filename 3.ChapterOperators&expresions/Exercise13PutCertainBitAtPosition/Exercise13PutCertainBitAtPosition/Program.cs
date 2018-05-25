using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13PutCertainBitAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: ");
            int bitPosition = int.Parse(Console.ReadLine());
            Console.Write("Enter value 1 or 0: ");
            int bitValue = int.Parse(Console.ReadLine());

            if (bitValue == 0)
            {
                number = number & (~(1 << bitPosition));
            }
            else
            {
                number = number | (1 << bitPosition);
            }

            Console.WriteLine(number);
        }
    }
}
