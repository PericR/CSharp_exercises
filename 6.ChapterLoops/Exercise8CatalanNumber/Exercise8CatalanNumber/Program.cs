using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8CatalanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            long n = long.Parse(Console.ReadLine());
            long nominator = 1;
            long denumerator = 1;

            for (long i = n + 2; i <= (2 * n); i++)
            {
                nominator *= i;
            }

            for (long i = 2; i <= n; i++) 
            {
                denumerator *= i;
            }

            long result = nominator / denumerator;
            Console.WriteLine(result);
        }
    }
}
