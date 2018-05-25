using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.PrintNumbs1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
    }
}
