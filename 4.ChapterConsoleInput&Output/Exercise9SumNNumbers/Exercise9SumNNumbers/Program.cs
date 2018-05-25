using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9SumNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your's numbers: ");
            for(int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of your numbers is: {0}", sum);
        }
    }
}
