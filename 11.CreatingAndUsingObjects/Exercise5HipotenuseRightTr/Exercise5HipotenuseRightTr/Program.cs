using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5HipotenuseRightTr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());

            double hypotenuse = (a * a) + (b * b);
            hypotenuse = Math.Sqrt(hypotenuse);

            Console.WriteLine(hypotenuse);
        }
    }
}
