using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coeficients for quadratic equation: ax^2 + bx + c");
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateQuadraticEquation(a, b, c));
        }

        static string CalculateQuadraticEquation(int a, int b,int c)
        {
            int d = (b * b) - (4 * a * c);
            string result;

            if (d > 0)
            {
                double x1 = ((b * -1) + (Math.Sqrt(d))) / (2 * a);
                double x2 = ((b * -1) - (Math.Sqrt(d))) / (2 * a);

                result = "X1=" + x1 + ", X2=" + x2;
            }
            else if (d < 0)
            {
                int x = (-1 * b) / (2 * a);
                result = "X=" + x;
            }
            else
            {
                result = "No real roots";
            }

            return result;
        }
    }
}
