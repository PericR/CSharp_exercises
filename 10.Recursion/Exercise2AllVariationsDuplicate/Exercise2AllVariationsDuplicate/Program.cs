using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2AllVariationsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            int[] variations = new int[k];

            GenerateVariaton(k, n, 0, variations);
        }

        static void GenerateVariaton(int k, int n, int count, int[] variations)
        {
            if (count == k)
            {
                PrintVariation(variations);
                return;
            }

            for(int i = 1; i <= n; i++)
            {
                variations[count] = i;
                GenerateVariaton(k, n, count + 1, variations);
            }
        }

        static void PrintVariation(int[] variation)
        {
            foreach(int i in variation)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
    }
}
