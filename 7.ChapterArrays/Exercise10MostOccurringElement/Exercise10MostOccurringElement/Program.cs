using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10MostOccurringElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = FillArray(n);
            PrintArray(array);

            int currentBest = array[0];
            int bestCount = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != int.MinValue) 
                {
                    int count = 1;

                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                            array[j] = int.MinValue;
                        }
                    }

                    if (count > bestCount)
                    {
                        currentBest = array[i];
                        bestCount = count;
                    }
                }
            }

            Console.WriteLine("Most occurring element is {0}, and it occurrs {1} times.", currentBest, bestCount);
            PrintArray(array);
        }

        static int[] FillArray(int n)
        {
            Random rand = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, 10);
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach(int number in array)
            {
                Console.Write("{0}, ", number);
            }

            Console.WriteLine();
        }
    }
}
