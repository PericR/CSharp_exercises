using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11NumbOfZeroAtFactEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            long fac = 1;

            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }

            Console.WriteLine(n / 5);
            Console.WriteLine(fac);
        }
    }
}
