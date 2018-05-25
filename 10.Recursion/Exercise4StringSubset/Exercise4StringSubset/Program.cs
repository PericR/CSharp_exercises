using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4StringSubset
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            string[] words = { "test", "rock", "fun", "wind", "water", "fire" };
            int[] variations = new int[k];

            GenerateVariaton(k, words.Length, 0, variations, words);
        }

        static void GenerateVariaton(int k, int n, int count, int[] variations, string[] words)
        {
            if (count == k)
            {
                PrintVariation(variations, words);
                return;
            }

            for (int i = 0; i < n; i++)
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
                Console.Write("{0}, ", words[i]);
            }
            Console.WriteLine();
        }
    }
}
