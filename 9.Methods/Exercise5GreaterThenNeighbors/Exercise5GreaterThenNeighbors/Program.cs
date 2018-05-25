using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5GreaterThenNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 3, 4 };
            int index = 1;

            Console.WriteLine(GreaterThanNeighbours(array, index));
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
    }
}
