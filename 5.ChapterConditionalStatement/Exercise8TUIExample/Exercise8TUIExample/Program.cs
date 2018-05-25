using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8TUIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:\n0. for integer\n1. for double\n2. for string");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 0:
                    Console.Write("Enter integer to increase it for 1: ");
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine((integer + 1));
                    break;
                case 1:
                    Console.Write("Enter integer to increase it for 1: ");
                    double number = double.Parse(Console.ReadLine());
                    number += 1d;
                    Console.WriteLine(number);
                    break;
                case 2:
                    Console.Write("Enter string: ");
                    string str = Console.ReadLine() + "*";
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
