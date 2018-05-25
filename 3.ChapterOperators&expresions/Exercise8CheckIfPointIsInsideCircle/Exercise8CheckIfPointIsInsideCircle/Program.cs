using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8CheckIfPointIsInsideCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter point x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter point y: ");
            float y = float.Parse(Console.ReadLine());
            Console.Write("Enter radius of circle: ");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine(CheckIfPointIsInsideCircle(x, y, radius) ? "Point is in circle." : "Point is not in a circle.");
        }

        static bool CheckIfPointIsInsideCircle(float x, float y, float radius)
        {
            return (x * x) + (y * y) <= (radius * radius);
        }
    }
}
