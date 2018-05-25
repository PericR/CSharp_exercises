using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2MaximalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(Max(2000000000, -2000000001), 2000000002));
        }

        static int Max(int a, int b)
        {
            int max = a;
            if (b > a)
            {
                max = b;
            }

            return max;
        } 
    }
}
