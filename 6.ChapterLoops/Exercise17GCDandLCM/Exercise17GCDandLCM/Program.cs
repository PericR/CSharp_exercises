using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17GCDandLCM
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        static int GreatestCommonDivisor(int a, int b)
        {
            int first = Math.Max(a, b);
            int second = Math.Min(a, b);
            int result = 0;

            do
            {
                result = first % second;
                first = second;
                second = result;
            }
            while (result > 0);

            return first;
        }

        static int LeastCommonMultiple(int a, int b)
        {
            int first = Math.Max(a, b);
            int second = Math.Min(a, b);
            int result = (Math.Abs(first * second)) / (GreatestCommonDivisor(a, b));

            return result;
        }
    }
}
