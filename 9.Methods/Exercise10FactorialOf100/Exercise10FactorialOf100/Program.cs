using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise10FactorialOf100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n!: ");
            int factoriel = int.Parse(Console.ReadLine());

            BigInteger number = 1;

            for(int i = 2; i <= factoriel; i++)
            {
                number *= i;
            }
        }
    }
}
