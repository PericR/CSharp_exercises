using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1SimulateLoopsRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            NestedLoop(n - 1, n);
        }

        static void NestedLoop(int k, int n)
        {
            if (k < 0)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                NestedLoop(k - 1, n);
            }
        }
    }
}
