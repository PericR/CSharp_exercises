using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1ReadNumbsAndPrintSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter next number: ");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of entered numbers is: {0}", sum);
        }
    }
}
