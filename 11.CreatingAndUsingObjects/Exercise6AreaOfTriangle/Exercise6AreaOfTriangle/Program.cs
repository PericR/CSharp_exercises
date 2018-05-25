using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for calculating triangle area by\n1 three sides\n2 side and altitude to it\n3 two sides and the angle between them in degrees");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                float c = float.Parse(Console.ReadLine());

                Console.WriteLine(Triangle.CalculateArea(a, b, c));
            }
            else if (choice == 2)
            {
                Console.Write("Enter a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Enter h: ");
                float h = float.Parse(Console.ReadLine());

                Console.WriteLine(Triangle.CalculateArea(a, h));
            }
            else if (choice == 3)
            {
                Console.Write("Enter a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Enter degree: ");
                double degree = double.Parse(Console.ReadLine());

                Console.WriteLine(Triangle.CalculateArea(a, b, degree));
            }
            else
            {
                Console.WriteLine("Wrong input number!!");
            }

        }
    }
}
