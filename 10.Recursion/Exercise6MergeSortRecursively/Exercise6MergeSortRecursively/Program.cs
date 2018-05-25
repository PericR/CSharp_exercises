using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6MergeSortRecursively
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size for the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = FillArray(n);
            int[] current = new int[n];

            Merge(numbers, current, 0, n);

            foreach (int i in numbers)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();

        }        

        static void Merge(int[] numbers, int[] current, int start, int end)
        {
            if ((end - start) < 2)
            {
                return;
            }

            int middle = (start + end) / 2;
            Merge(numbers, current, start, middle);
            Merge(numbers, current, middle, end);

            Compare(numbers, current, start, middle, end);
        }

        static void Compare(int[] numbers, int[] current, int start, int middle, int end)
        {
            int i = start;
            int j = middle;
            current = CopyArray(numbers);

            for (int count = start; count < end; count++)
            {
                if (i >= middle)
                {
                    numbers[count] = current[j];
                    j++;
                    continue;
                }

                if (j >= end)
                {
                    numbers[count] = current[i];
                    i++;
                    continue;
                }

                if (current[i] >= current[j])
                {
                    numbers[count] = current[j];
                    j++;
                }
                else
                {
                    numbers[count] = current[i];
                    i++;
                }
            }
        }

        static int[] FillArray(int n)
        {
            int[] randomArray = new int[n];
            Random rand = new Random();

            for(int i = 0; i < n; i++)
            {
                randomArray[i] = rand.Next(-100, 100);
            }

            return randomArray;
        }
        static int[] CopyArray(int[] numbers)
        {
            int[] temp = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                temp[i] = numbers[i];
            }

            return temp;
        }
    }
}
