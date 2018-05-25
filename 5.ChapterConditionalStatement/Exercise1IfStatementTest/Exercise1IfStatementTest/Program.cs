using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1IfStatementTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Console.WriteLine("First {0}, second {1}.", a, b);
        }
    }
}
