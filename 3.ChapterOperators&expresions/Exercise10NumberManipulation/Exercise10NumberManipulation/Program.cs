using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10NumberManipulation
{
    class NumberManipulation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter four-digit number: ");
            int number = int.Parse(Console.ReadLine());

            int d = number % 10;
            int c = (number / 10) % 10;
            int b = (number / 100) % 10;
            int a = (number / 1000) % 10;

            Console.WriteLine("Sum: {0}", (a + b + c + d));
            Console.WriteLine("reverse: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit first: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second and third swap: {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
