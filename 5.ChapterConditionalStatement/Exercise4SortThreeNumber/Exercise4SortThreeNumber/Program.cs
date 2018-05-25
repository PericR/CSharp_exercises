using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4SortThreeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yours numbers: ");
            int[] numbs = new int[3];

            for(int i = 0; i < 3; i++)
            {
                numbs[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbs);

            foreach(int i in numbs)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
    }
}
