using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberInSeveralWays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}".PadLeft(15), number);
            Console.WriteLine("{0:x}".PadLeft(15), number);
            Console.WriteLine("{0:p}".PadLeft(15), number);
            Console.WriteLine("{0:c}".PadLeft(15), number);
            Console.WriteLine("{0:e}".PadLeft(15), number);

        }
    }
}
