using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2PerimeterAndAreaCirce
{
    class PerimeterAndAreaCirce
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius for circle: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("For radius= {0} area is: {1}, perimeter is: {2}", radius, CalculateAreaOfCircle(radius), CalculatePerimeterOfCircle(radius));
        }

        static double CalculatePerimeterOfCircle(double radius)
        {
            return 2 * Math.PI * radius;
        }

        static double CalculateAreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
