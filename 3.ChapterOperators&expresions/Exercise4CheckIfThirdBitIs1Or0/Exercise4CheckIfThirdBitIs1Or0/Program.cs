using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4CheckIfThirdBitIs1Or0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check its third bit: ");
            int num = int.Parse(Console.ReadLine());

            bool bit3 = (num & 8) != 0;
            Console.WriteLine(bit3 ? "1" : "0");
        }
    }
}
