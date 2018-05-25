using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16RandomOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int numb = int.Parse(Console.ReadLine());
            int[] arr = new int[numb];

            for (int i = 0; i < numb; i++)
            {
                arr[i] = i + 1;
            }

            Random rand = new Random();

            for (int i = 0; i <= numb / 2; i++)
            {
                int r1 = rand.Next(0, numb);
                int r2 = rand.Next(0, numb);
                int temp = arr[r1];

                arr[r1] = arr[r2];
                arr[r2] = temp;
            }

            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }
        }
    }
}
