using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7GreatestOf5Numbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers: ");
            int biggestNumber = int.MinValue;
            int curentNumber;

            for(int i = 0; i < 5; i++)
            {
                curentNumber = int.Parse(Console.ReadLine());

                if (curentNumber > biggestNumber)
                {
                    biggestNumber = curentNumber;
                }
            }

            Console.WriteLine("Bigest number is: {0}", biggestNumber);
        }
    }
}
