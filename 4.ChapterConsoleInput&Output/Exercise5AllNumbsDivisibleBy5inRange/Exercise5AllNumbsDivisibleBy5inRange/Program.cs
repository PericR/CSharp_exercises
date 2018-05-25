using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5AllNumbsDivisibleBy5inRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number, first to be smaler: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first < second)
            {
                PrintAllNumbsDivisibleBy5InRange(first, second);
            }
            else
            {
                Console.WriteLine("First number shoud be smaler than second!!!");
            }
        }

        static void PrintAllNumbsDivisibleBy5InRange(int first, int second)
        {
            first = (first - (first % 5) + 5);

            for(int i = first; i < second; i += 5)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
    }
}
