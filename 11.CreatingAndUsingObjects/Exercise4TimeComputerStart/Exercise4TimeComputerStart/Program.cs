using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4TimeComputerStart
{
    class Program
    {
        static void Main(string[] args)
        {
            int tick = Environment.TickCount;
            Console.WriteLine("{0} days, {1} hour, {2} minutes", (((tick / 1000) / 60) / 60) / 24, ((tick / 1000) / 60) / 60, (tick / 1000) / 60);
        }
    }
}
