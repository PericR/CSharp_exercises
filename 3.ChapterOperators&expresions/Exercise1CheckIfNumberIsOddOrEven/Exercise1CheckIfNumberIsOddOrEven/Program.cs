using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1CheckIfNumberIsOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check if it is odd or even: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
        }
    }
}
