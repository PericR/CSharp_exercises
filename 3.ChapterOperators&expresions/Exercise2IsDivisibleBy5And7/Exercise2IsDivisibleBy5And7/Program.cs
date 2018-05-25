using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2IsDivisibleBy5And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check if it is divisible by 5 and 7: ");
            int number = int.Parse(Console.ReadLine());
            bool isDivisible = false;

            if (number % 5 == 0 && number % 7 == 0)
            {
                isDivisible = true;
            }

            Console.WriteLine(isDivisible);
        }
    }
}
