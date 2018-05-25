using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9.CalcSomeWeirdSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            decimal sum = 1;
            decimal factorial = 1;
            decimal power = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power *= x;

                sum += (factorial / power);
            }

            Console.WriteLine(sum);
        }
    }
}
