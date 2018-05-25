using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1ElementIndexTimeFive
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                array[i] = i * 5;
            }

            foreach(int i in array)
            {
                Console.WriteLine("Value: {0}", i);
            }
        }
    }
}
