using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3PrintSmallestAndLarge
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int n;
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.Write("Please tell me how many numbers are you gona use: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter {0}. number: ", i);
                number = int.Parse(Console.ReadLine());
                min = CompareMin(number, min);
                max = CompareMax(number, max);
            }

            Console.WriteLine("Smallest number: {0}.\nLargest number: {1}.", min, max);
        }

        static int CompareMin(int current, int min)
        {
            if (current < min)
            {
                min = current;
            }

            return min;
        }
        static int CompareMax(int current, int max)
        {
            if (current > max)
            {
                max = current;
            }
            return max;
        }
    }
}
