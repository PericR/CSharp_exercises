using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6FirstBiggerThanNeighbou
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            FillArray(array);

            int index = GetIndexOfFirstElementGreaterThenItsNeighbors(array);

            Console.WriteLine("Index is {0}", index);
        }

        static void FillArray(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-1000, 1000);
            }
        }

        static bool GreaterThanNeighbours(int[] array, int index)
        {
            bool isGreater = false;

            if (index == 0)
            {
                if (array[0] > array[1])
                {
                    isGreater = true;
                }
            }
            else if (index == array.Length - 1)
            {
                if (array[index] > array[index - 1])
                {
                    isGreater = true;
                }
            }
            else
            {
                if (array[index] > array[index - 1] && array[index] > array[index + 1])
                {
                    isGreater = true;
                }
            }

            return isGreater;
        }

        static int GetIndexOfFirstElementGreaterThenItsNeighbors(int[] array)
        {
            int index = -1;

            for(int i = 0; i < array.Length; i++)
            {
                if(GreaterThanNeighbours(array, i))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
