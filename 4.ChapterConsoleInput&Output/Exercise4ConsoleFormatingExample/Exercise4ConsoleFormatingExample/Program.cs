using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4ConsoleFormatingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexNumber = 200;
            Console.WriteLine("|0x{0,-8:X}|", hexNumber);
            double fractNum = -1.856;
            Console.WriteLine("|{0,-10:f2}|", fractNum);
            double fractNumber = 3.134;
            Console.WriteLine("|{0,-10:f2}|", fractNumber);
        }
    }
}
