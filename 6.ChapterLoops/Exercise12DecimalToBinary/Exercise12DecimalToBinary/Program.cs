using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            do
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            while (n > 0);

            Console.WriteLine(binary);
        }
    }
}
