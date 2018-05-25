using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2NotDivisibleBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                if (!(i % (3 * 7) == 0))
                {
                    Console.Write("{0}, ", i);
                }
            }
        }
    }
}
