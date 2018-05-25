using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9WorkDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = WorkDays.CountWorkDays(new DateTime(2020, 1, 1));

            Console.WriteLine(workingDays);
        }
    }
}
