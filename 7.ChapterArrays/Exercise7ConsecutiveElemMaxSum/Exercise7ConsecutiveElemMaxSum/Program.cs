using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7ConsecutiveElemMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K (must be less then N): ");
            int k = int.Parse(Console.ReadLine());
            int biggestSum = 0;
            int bestStart = 0;
            int currentSum = 0;

            int[] array = FillArrayWithIntegers(n);
            PrintArray(array);

            for (int i = 0; i < array.Length; i++) 
            {
                if (k > i)
                {
                    currentSum += array[i];
                    biggestSum = currentSum;
                }
                else
                {
                    currentSum -= array[(i - k)];
                    currentSum += array[i];

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        bestStart = i - k + 1;
                    }
                }
            }

            Console.WriteLine("Biggest sum is: {0}", biggestSum);
            Console.WriteLine("Element of biggest sum are: ");
            for(int i = bestStart; i < bestStart + k; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
        }

        static int[] FillArrayWithIntegers(int n)
        {
            Random rand = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, 20);
            }

            return array;
        }
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();
        }
    }
}
