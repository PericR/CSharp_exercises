using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2CheckEqualArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter lenght of first array: ");
            int[] firstArray = new int[int.Parse(Console.ReadLine())];
            for(int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Value at index[{0}]: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter lenght of seccond array: ");
            int[] seccondArray = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < seccondArray.Length; i++)
            {
                Console.Write("Value at index[{0}]: ", i);
                seccondArray[i] = int.Parse(Console.ReadLine());
            }

            bool equal = firstArray.Length == seccondArray.Length;

            if (equal)
            {
                for(int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != seccondArray[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            Console.WriteLine("Arrays are {0}.", equal ? "equal": "not equal");
        }
    }
}
