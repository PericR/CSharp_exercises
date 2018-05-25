using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5AllStringSubsetOfSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "", "test", "rock", "fun", "wind", "water", "fire" };
            int k = words.Length;
            int[] variations = new int[k];

            for (int i = 0; i <= k; i++)
            {
                GenerateVariaton(i, words.Length, 0, variations, words);
            }
        }

        static void GenerateVariaton(int k, int n, int count, int[] variations, string[] words)
        {
            if (count == k)
            {
                PrintVariation(variations, words);
                return;
            }

            for (int i = 1; i < n; i++)
            {
                variations[count] = i;
                if (count > 0)
                {
                    if (variations[count - 1] >= i)
                    {
                        variations[count] = variations[count - 1] + 1;
                        i = variations[count - 1] + 1;
                    }
                }
                if (variations[count] >= n)
                {
                    break;
                }
                GenerateVariaton(k, n, count + 1, variations, words);
            }
        }

        static void PrintVariation(int[] variation, string[] words)
        {
            foreach (int i in variation)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.Write("{0}, ", words[i]);
            }
            Console.WriteLine();
        }
    }
}
