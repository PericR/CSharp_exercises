using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3EqualNumbers
{
    class EqualNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number to see if the are equal to 0.000001: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            bool equal = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(equal);
        }
    }
}
