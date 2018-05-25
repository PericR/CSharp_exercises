using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4CountNumbOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 2, 2, 5, 1, -8, 7, 2 };
            int number = 2;

            int numberOfOccurences = CountOccurences(number, array);
            Console.WriteLine("Number {0} occurs {1} times in array.", number, numberOfOccurences);
        }

        static int CountOccurences(int number, int[] array)
        {
            int count = 0;

            foreach(int currentNumber in array)
            {
                if (currentNumber == number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
