using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6PerimeterAndAreaOfRectangle
{
    class CalculatePerimeterAndAreaOfRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("For entered rectangle perimeter is: {0}, and area is: {1}", CalculatePerimeter(width, height), CalculateArea(width, height));
        }

        static float CalculatePerimeter(float width, float height)
        {
            return (2 * width) + (2 * height);
        }
        static float CalculateArea(float width, float height)
        {
            return width * height;
        }
    }
}
