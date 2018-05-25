using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());            

            int[] numbers = FillArray(size);
            Array.Sort(numbers);

            Console.Write("Enter number to check: ");
            int n = int.Parse(Console.ReadLine());

            bool end = false;
            int left = 0;
            int right = numbers.Length - 1;
            int middle = (left + right) / 2;

            do
            {
                if (numbers[middle] == n)
                {
                    end = true;
                    Console.WriteLine("Number is found at {0} place", middle);
                }
                else if (numbers[middle] > n)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
               
                if (left > right)
                {
                    end = true;
                    Console.WriteLine("Number isn't in the array.");
                }

                middle = (left + right) / 2;
            } while (!end);
        }

        static int[] FillArray(int size)
        {
            Random rand = new Random();
            int[] numbers = new int[size];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-1000, 1000);
            }

            return numbers;
        }
    }
}
