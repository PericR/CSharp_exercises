using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9MaximalSubsequenceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int currentSum = 0;
            int maxSum = int.MinValue;
            int start = 0;
            int end = 1;

            foreach(int number in array)
            {
                currentSum += number;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            Console.WriteLine("Biggest sum in this sequence is: {0}", maxSum);
        }
    }
}
