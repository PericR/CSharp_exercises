using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6AreaOfTriangle
{
    static class Triangle
    {
        public static double CalculateArea(float a, float b, float c)
        {
            double p = (a + b + c) / 2;
            double s = p * (p - a) * (p - b) * (p - c);
            s = Math.Sqrt(s);

            return s;
        }

        public static double CalculateArea(float a, float h)
        {
            return (a * h) / 2;

        }

        public static double CalculateArea(float a, float b, double degree)
        {
            return (a * b * Math.Sin(degree)) / 2;
        }
    }
}
