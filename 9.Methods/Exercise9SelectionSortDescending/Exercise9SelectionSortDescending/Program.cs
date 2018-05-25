using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9SelectionSortDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = FillArray(50);
            
            for(int i = 0; i < array.Length - 1; i++)
            {
                int positionOfBiggest = FindPositionOfBiggestElementInRange(i, array);
                int temp = array[i];

                array[i] = array[positionOfBiggest];
                array[positionOfBiggest] = temp;
            }
        }

        static int FindPositionOfBiggestElementInRange(int start, int[] array)
        {
            int bestPosition = start;

            for(int i = start + 1; i < array.Length; i++)
            {
                if (array[bestPosition] < array[i])
                {
                    bestPosition = i;
                }
            }

            return bestPosition;
        }

        static int[] FillArray(int size)
        {
            Random rand = new Random();
            int[] array = new int[size];

            for(int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 100);
            }

            return array;
        }
    }
}
