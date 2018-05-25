using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] numbers = FillArray(lenght);
            MergeSortRecursive(numbers, 0, lenght - 1);

            foreach(int n in numbers)
            {
                Console.Write("{0,3}, ", n);
            }
            Console.WriteLine();

        }

        static int[] FillArray(int size)
        {
            int[] array = new int[size];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }

            return array;
        }

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, leftEnd, numElements, temporaryPosition;

            leftEnd = (mid - 1);
            temporaryPosition = left;
            numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[temporaryPosition++] = numbers[left++];
                else
                    temp[temporaryPosition++] = numbers[mid++];
            }

            while (left <= leftEnd)
            {
                temp[temporaryPosition++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[temporaryPosition++] = numbers[mid++];
            }

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSortRecursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortRecursive(numbers, left, mid);
                MergeSortRecursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}
