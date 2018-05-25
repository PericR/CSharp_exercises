using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11SumOfCertainNumbersS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = FillArray(n);
            PrintArray(array);
            Console.Write("Enter sum: ");
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < (array.Length - 1); i++)
            {
                int count = array[i];
                int end = 1;

                for(int j = i + 1; j < array.Length; j++)
                {
                    count += array[j];

                    if (count >= sum)
                    {
                        end = j;
                        break;
                    }
                }

                if (count == sum)
                {
                    PrintSequence(array, i, end);
                    Console.Write("sum is: {0}", count);
                    break;
                }
            }

        }

        static int[] FillArray(int n)
        {
            Random rand = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-10, 10);
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
        
        static void PrintSequence(int[] array, int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write("{0}, ", array[i]);
            }

            Console.WriteLine();
        }
    }
}
