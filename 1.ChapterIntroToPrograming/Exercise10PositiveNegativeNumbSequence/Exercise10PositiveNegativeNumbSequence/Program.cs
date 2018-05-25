using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10PositiveNegativeNumbSequence
{
    class PrintPositiveNegativeSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 102; i = i + 2) 
            {
                Console.WriteLine(i);
                Console.WriteLine("-" + (i+1));
            }
        }
    }
}
