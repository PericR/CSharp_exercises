using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            int myAge;
            Console.Write("Enter your age: ");
            myAge = int.Parse(Console.ReadLine());

            DateTime myAgePlus10 = new DateTime(myAge,1,1);
            Console.WriteLine(myAgePlus10.AddYears(10).Year);
            
        }
    }
}
