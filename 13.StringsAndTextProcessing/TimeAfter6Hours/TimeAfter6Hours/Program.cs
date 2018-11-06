using System;
using System.Globalization;

namespace TimeAfter6Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date: ");
            string date = Console.ReadLine();
            DateTime dateCurrent = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss.ffffff", CultureInfo.InvariantCulture);
            DateTime dateAfter6AndHalfHours = dateCurrent.AddHours(6.5);
            Console.WriteLine(dateAfter6AndHalfHours);
        }
    }
}
