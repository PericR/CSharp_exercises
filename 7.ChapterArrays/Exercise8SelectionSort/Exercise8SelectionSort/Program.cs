using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8SelectionSort
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = FillArray(n);
            PrintArray(array);
            
            for (int i = 0; i < array.Length; i++) 
            {
                int temp = i;
                int currentSmallest = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < currentSmallest)
                    {
                        temp = j;
                        currentSmallest = array[j];
                    }
                }

                array[temp] = array[i];
                array[i] = currentSmallest;
            }

            PrintArray(array);
        }

        static int[] FillArray(int n)
        {
            Random rand = new Random();
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100,100);
            }

            return array;
        }
        static void PrintArray(int[] array)
        {
            foreach(int number in array)
            {
                Console.WriteLine("{0}, ", number);
            }

            Console.WriteLine();
        }
    }
}
