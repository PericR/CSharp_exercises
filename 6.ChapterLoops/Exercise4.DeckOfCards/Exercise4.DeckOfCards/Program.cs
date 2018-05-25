using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4.DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDeck();
        }

        static void PrintDeck()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    switch (i)
                    {
                        case 1:
                            Console.Write("club ");
                            break;

                        case 2:
                            Console.Write("diamond ");
                            break;

                        case 3:
                            Console.Write("heart ");
                            break;

                        case 4:
                            Console.Write("spades ");
                            break;
                    }

                    switch (j)
                    {
                        case 11:
                            Console.Write("J, ");
                            break;

                        case 12:
                            Console.Write("Q, ");
                            break;

                        case 13:
                            Console.Write("K, ");
                            break;

                        case 14:
                            Console.Write("A, ");
                            break;

                        default:
                            Console.Write("{0}, ", j);
                            break;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
