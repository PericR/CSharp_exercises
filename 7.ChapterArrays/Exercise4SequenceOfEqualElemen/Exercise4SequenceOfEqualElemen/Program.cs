using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4SequenceOfEqualElemen
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10] { 1, 1, 1, 1, 2, 2, 1, 1, 2, 1 };

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int bestPosition = 0; 
            int longestSequence = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int count = i;
                int curentSequence = 1;

                while (arr[count] == arr[count + 1])
                {
                    curentSequence++;

                    if (count + 1 == arr.Length - 1)
                    {
                        break;
                    }

                    count++;
                }

                if (curentSequence > longestSequence)
                {
                    bestPosition = i;
                    longestSequence = curentSequence;
                }
            }

            for(int i = 0; i < longestSequence; i++)
            {
                Console.Write("{0} ", arr[bestPosition]);
            }
            Console.WriteLine();
        }
    }
}
