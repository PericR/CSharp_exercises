using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9CheckForSubset0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers you want to check!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a < 0 || b < 0 || c < 0 || d < 0 || e < 0)
            {
                Console.Write(a + b == 0 ? "{0}+{1}=0, " : "", a, b);
                Console.Write(a + c == 0 ? "{0}+{1}=0, " : "", a, c);
                Console.Write(a + d == 0 ? "{0}+{1}=0, " : "", a, d);
                Console.Write(a + e == 0 ? "{0}+{1}=0, " : "", a, e);
                Console.Write(b + c == 0 ? "{0}+{1}=0, " : "", b, c);
                Console.Write(b + d == 0 ? "{0}+{1}=0, " : "", b, d);
                Console.Write(b + e == 0 ? "{0}+{1}=0, " : "", b, e);
                Console.Write(c + d == 0 ? "{0}+{1}=0, " : "", c, d);
                Console.Write(c + e == 0 ? "{0}+{1}=0, " : "", c, e);
                Console.Write(d + e == 0 ? "{0}+{1}=0, " : "", d, e);

                Console.Write(a + b + c == 0 ? "{0}+{1}+{2}=0, " : "", a, b, c);
                Console.Write(a + b + d == 0 ? "{0}+{1}+{2}=0, " : "", a, b, d);
                Console.Write(a + b + e == 0 ? "{0}+{1}+{2}=0, " : "", a, b, e);
                Console.Write(a + c + d == 0 ? "{0}+{1}+{2}=0, " : "", a, c, d);
                Console.Write(a + c + e == 0 ? "{0}+{1}+{2}=0, " : "", a, c, e);
                Console.Write(a + d + e == 0 ? "{0}+{1}+{2}=0, " : "", a, d, e);
                Console.Write(b + c + d == 0 ? "{0}+{1}+{2}=0, " : "", b, c, d);
                Console.Write(b + c + e == 0 ? "{0}+{1}+{2}=0, " : "", b, c, e);
                Console.Write(c + d + e == 0 ? "{0}+{1}+{2}=0, " : "", c, d, e);

                Console.Write(a + b + c + d == 0 ? "{0}+{1}+{2}+{3}=0, " : "", a, b, c, d);
                Console.Write(a + b + c + e == 0 ? "{0}+{1}+{2}+{3}=0, " : "", a, b, c, e);
                Console.Write(a + b + d + e == 0 ? "{0}+{1}+{2}+{3}=0, " : "", a, b, d, e);
                Console.Write(a + c + d + e == 0 ? "{0}+{1}+{2}+{3}=0, " : "", a, c, d, e);
                Console.Write(b + c + d + e == 0 ? "{0}+{1}+{2}+{3}=0, " : "", b, c, d, e);

                Console.Write(a + b + c + d + e == 0 ? "{0}+{1}+{2}+{3}=0, " : "", a, b, c, d, e);
            }
            else
            {
                Console.Write("There is no subset with sum of zero!");
            }
        }
    }
}
