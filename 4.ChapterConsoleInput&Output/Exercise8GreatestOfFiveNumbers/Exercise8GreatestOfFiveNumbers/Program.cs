using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8GreatestOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNumber;
            int currentNumber;

            Console.WriteLine("Enter five numbers: ");
            biggestNumber = int.Parse(Console.ReadLine());
            for(int i = 0; i < 4; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
            }

            Console.WriteLine("Biggest number is: {0}", biggestNumber);
        }
    }
}
