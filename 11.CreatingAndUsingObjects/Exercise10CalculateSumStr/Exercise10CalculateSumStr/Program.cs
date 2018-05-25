using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10CalculateSumStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integers: ");
            string integers = Console.ReadLine();
            string[] integersSplited = integers.Split(' ');
            int sum = 0;

            foreach(string number in integersSplited)
            {
                int current = int.Parse(number);
                sum += current;
            }

            Console.WriteLine(sum);
        }
    }
}
