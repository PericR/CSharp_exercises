using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7.CalcWithFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            int result = 1;

            do
            {
                Console.WriteLine("Enter N and K in folowing format 1 < K < N.");

                Console.Write("Enter N: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("Enter K: ");
                k = int.Parse(Console.ReadLine());
            }
            while (!((1 < k) && (k < n)));

            for(int i = 1; i <= k; i++)
            {
                result *= i;
            }

            for (int i = n - k + 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
