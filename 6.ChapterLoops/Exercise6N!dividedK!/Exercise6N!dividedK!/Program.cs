using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6N_dividedK_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;

            do
            {
                Console.WriteLine("Enter n and k in format 1 < k < n.");

                Console.WriteLine("Enter n: ");
                n = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter k: ");
                k = int.Parse(Console.ReadLine());
            }
            while (!((1 < k) && (k < n)));

            int result = 1;

            for(int i = k + 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine("N! / K! = {0}", result);
        }
    }
}
