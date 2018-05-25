using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7AllPermutatonsOfTheNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = FillArray(n);

            Perm(n - 1, numbers);
        }

        static int[] FillArray(int n)
        {
            int[] numbers = new int[n];
            for(int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            return numbers;
        }

        static void Perm(int k, int[] numbers)
        {
            if (k == 0)
            {
                foreach(int i in numbers)
                {
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
                return;
            }

            Perm(k - 1, numbers);

            for(int i = 0; i < k; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[k];
                numbers[k] = temp;

                Perm(k - 1, numbers);

                temp = numbers[i];
                numbers[i] = numbers[k];
                numbers[k] = temp;
            }
        }
    }
}
