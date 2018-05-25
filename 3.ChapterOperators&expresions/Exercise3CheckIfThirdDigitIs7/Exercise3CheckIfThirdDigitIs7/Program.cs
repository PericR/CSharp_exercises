using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3CheckIfThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number bigger then 100: ");
            int number = int.Parse(Console.ReadLine());

            number /= 100;
            Console.WriteLine(number % 10 == 7 ? "Third digit is 7." : "Third digit isn't 7.");
        }
    }
}
