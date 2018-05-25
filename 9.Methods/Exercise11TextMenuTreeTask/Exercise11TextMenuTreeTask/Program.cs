using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11TextMenuTreeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = GetChoice();

            switch (choice)
            {
                case 1:
                    ReverseNumber();
                    break;
                case 2:
                    CalculateAverage();
                    break;
                case 3:
                    CalculateEquation();
                    break;
                default:
                    Console.WriteLine("Wrong choice!!!");
                    break;
            }

        }

        static int GetChoice()
        {
            int choise = 0;
            bool isGoodChoise = false;

            while(!isGoodChoise)
            {
                Console.WriteLine("Dear user, please enter number to:\n1-reverse digits in number\n2-Calculate average\n3-Solve linear equation (a*x+b)");
                isGoodChoise = int.TryParse(Console.ReadLine(), out choise);

                if (choise < 1 || choise > 3)
                {
                    isGoodChoise = false;
                }
            }

            return choise;
        }

        static void ReverseNumber()
        {
            
            int number = 1;

            do
            {
                Console.Write("Enter integer number in range 1-50 000 000 to reverse it: ");
                int.TryParse(Console.ReadLine(), out number);
            }
            while (number < 1 || number > 50000000);

            while (number > 0)
            {
                Console.Write("{0}", number % 10);
                number /= 10;
            }

            Console.WriteLine();
        }

        static void CalculateAverage()
        {
            double average = 0;
            double next = 1;
            int count = 0;

            do
            {
                Console.Write("Enter next number (zerro to finish, but only after at least one number is entered): ");

                if (double.TryParse(Console.ReadLine(), out next) && (next != 0))
                {
                    count++;
                }

                average += next;
            } while ((next != 0) || count == 0);

            average /= count;

            Console.WriteLine("Average is {0}", average);
        }

        static void CalculateEquation()
        {
            double a, b;

            do
            {
                Console.Write("Enter a: ");
                a = double.Parse(Console.ReadLine());
            }
            while (a == 0);

            Console.Write("Enter b: ");
            b = double.Parse(Console.ReadLine());

            double x = (-b / a);
            Console.WriteLine("x=={0}", x);
        }
    }
}
