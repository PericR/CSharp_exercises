using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5.SumOfNFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 1;
            int c;

            for(int i = 2; i < number; i++)
            {
                c = a + b;
                a = b;
                b = c;
                sum += c;
            }

            Console.Write("{0}, ", sum);
        }
    }
}
