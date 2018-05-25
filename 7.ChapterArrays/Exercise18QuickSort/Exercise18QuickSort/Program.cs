using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = FillArray(size);
            foreach(int i in numbers)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();

            QuickSort(numbers, 0, numbers.Length-1);

            foreach (int i in numbers)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }

        static int[] FillArray(int size)
        {
            int[] array = new int[size];
            Random rand = new Random();

            for(int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 100);
            }

            return array;
        }

        public static void QuickSort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }
    }
}
