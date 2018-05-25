using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24AllCombinatonsKElem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] variations = new int[k];

            for (int i = 0; i < k; i++)
            {
                variations[i] = i + 1;
            }

            while (variations[0] <= n-k+1)
            {

                Console.Write("(");

                foreach (int i in variations)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine(")");



                variations[k - 1]++;
                
                int place = k - 1;
                bool change = false;

                while (variations[place] > n - k + place + 1)
                {
                    place--;
                    if (place < 0)
                    {
                        change = false;
                        break;
                    }
                    variations[place]++;
                    change = true;
                }

                if (change)
                {
                    for (int i = place; i < k - 1; i++)
                    {
                        variations[i + 1] = variations[i] + 1;
                    }
                    change = false;
                }
            }
        }
    }
}
