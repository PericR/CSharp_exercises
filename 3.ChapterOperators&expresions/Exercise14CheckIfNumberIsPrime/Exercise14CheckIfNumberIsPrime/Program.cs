using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14CheckIfNumberIsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check if it is prime: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CheckIfPrime(number) ? "Number is prime." : "Number is not prime.");
        }

        static bool CheckIfPrime(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
