using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3BiggestNumbIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Biggest number is {0}", a);
                }
                else
                {
                    Console.WriteLine("Biggest number is {0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Biggest number is {0}", b);
                }
                else
                {
                    Console.WriteLine("Biggest number is {0}", c);
                }
            }
        }
    }
}
