using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            if (points >= 1 && points <= 3)
            {
                points *= 10;
                Console.WriteLine("Points: {0}", points);
            }
            else if (points >= 4 && points <= 6)
            {
                points *= 100;
                Console.WriteLine("Points: {0}", points);
            }
            else if (points >= 7 && points <= 9)
            {
                points *= 1000;
                Console.WriteLine("Points: {0}", points);
            }
            else
            {
                Console.WriteLine("Enter number is out of range!");
            }
        }
    }
}
