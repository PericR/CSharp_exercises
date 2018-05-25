using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2PlusMinusSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers: ");
            int nextNumber = 0;
            int negativeSignCounter = 0;

            for(int i = 0; i < 3; i++)
            {
                nextNumber = int.Parse(Console.ReadLine());

                if (nextNumber < 0)
                {
                    negativeSignCounter++;
                }
                else if (nextNumber == 0)
                {
                    break;
                }
            }

            if (nextNumber != 0)
            {
                if (negativeSignCounter % 2 != 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else
            {
                Console.WriteLine("Zerro occured!");
            }
        }
    }
}
