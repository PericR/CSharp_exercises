using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19SieveOfErathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100000001];

            for(int i=2;i< 100000001; i++)
            {
                numbers[i] = i;
            }

            for (int i = 2; i < 100000001; i++)
            {
                if (numbers[i] != 0)
                {
                    Console.Write("{0}, ", numbers[i]);
                    for (int j = i + i; j < 100000001; j += i)
                    {
                        numbers[j] = 0;
                    }
                }
            }
        }
    }
}
