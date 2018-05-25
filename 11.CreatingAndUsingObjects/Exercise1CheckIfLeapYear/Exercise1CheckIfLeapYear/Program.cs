using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1CheckIfLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} is leap? {1}", year, DateTime.IsLeapYear(year));
        }
    }
}
