using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtWithExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter integer to calculate square root: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input");
            }
            finally
            {
                Console.WriteLine("Good day");
            }
        }
    }
}
