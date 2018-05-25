using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23AllVariationsKElem
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

            for(int i = 0; i < k; i++)
            {
                variations[i] = 1;
            }

            while (variations[0] <= n)
            {

                Console.Write("(");

                foreach(int i in variations)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine(")");



                variations[k - 1]++;
                int check = variations[k - 1];
                int place = k - 1;

                while (check > n)
                {
                    if (variations[place] > n && place > 0)
                    {
                        variations[place] = 1;
                        place--;                        

                        variations[place]++;
                        check = variations[place];
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
