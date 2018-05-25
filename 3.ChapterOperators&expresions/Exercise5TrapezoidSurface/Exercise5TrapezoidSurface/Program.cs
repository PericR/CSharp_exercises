using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5TrapezoidSurface
{
    class TrapezoidSurface
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            float h = 0;

            Console.WriteLine("Enter a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter h: ");
            h = float.Parse(Console.ReadLine());

            Console.WriteLine("a= {0}, b= {1}, c= {2}", a, b, h);
            Console.WriteLine("Surface of trapezoid is: {0}", CalculateTrapezoidSurface(a, b, h));
        }

        static float CalculateTrapezoidSurface(float a, float b, float h)
        {
            float surface = (a + b) * h / 2;

            return surface;
        }
    }
}
