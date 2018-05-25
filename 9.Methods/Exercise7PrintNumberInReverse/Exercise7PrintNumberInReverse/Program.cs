using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7PrintNumberInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            PrintNumberInReverse(number);
        }

        static void PrintNumberInReverse(int number)
        {
            while (number > 0)
            {
                Console.Write(number % 10);
                number /= 10;
            }

            Console.WriteLine();
        }
    }
}
