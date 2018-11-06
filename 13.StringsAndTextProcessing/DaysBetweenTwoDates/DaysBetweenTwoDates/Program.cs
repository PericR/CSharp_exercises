using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate;
            DateTime secondDate;
            string date;
            Console.Write("Enter first date: ");
            date = Console.ReadLine();
            firstDate = ParseDate(date);

            Console.Write("Enter second date: ");
            date = Console.ReadLine();
            secondDate = ParseDate(date);

            TimeSpan result = firstDate - secondDate;

            Console.WriteLine(result);
        }

        static DateTime ParseDate(string dateString)
        {
            string[] date = dateString.Split('.');
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = int.Parse(date[2]);
            DateTime parsedDate = new DateTime(year, month, day);
            return parsedDate;
        }
    }
}
