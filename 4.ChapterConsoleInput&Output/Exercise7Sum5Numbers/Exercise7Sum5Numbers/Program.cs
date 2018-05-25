using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7Sum5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int curentNumber;
            Console.WriteLine("Enter five numbers to sum it: ");

            for(int i = 0; i < 5; i++)
            {
                bool input = int.TryParse(Console.ReadLine(), out curentNumber);

                if (!input)
                {
                    Console.WriteLine("Thats not a number, try aggain!");
                    i--;
                }
                else
                {
                    sum += curentNumber;
                }
            }

            Console.WriteLine("Sum of yours numbers is: {0}", sum);
        }
    }
}
