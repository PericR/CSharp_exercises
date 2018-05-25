using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;

            for(int i = 0; i < 100; i++)
            {
                Console.Write("{0}, ", a);
                c = a;
                a = a + b;
                b = c;
            }
        }
    }
}
