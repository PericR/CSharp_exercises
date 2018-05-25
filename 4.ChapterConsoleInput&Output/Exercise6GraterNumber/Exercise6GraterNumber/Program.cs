using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6GraterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Greater: {0}\nSmaler {1}", Math.Max(a, b), Math.Min(a, b));
        }
    }
}
