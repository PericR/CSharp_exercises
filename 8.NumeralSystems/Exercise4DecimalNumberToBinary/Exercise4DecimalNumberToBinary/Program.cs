using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4DecimalNumberToBinary
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number in decimal format: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int decimalNumb = decimalNumber;
            string binary = "";

            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }

            Console.WriteLine("{0} in binary is {1}", decimalNumb, binary);
        }
    }
}
