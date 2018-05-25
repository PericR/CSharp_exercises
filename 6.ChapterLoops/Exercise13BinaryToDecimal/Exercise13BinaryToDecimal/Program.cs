using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            string binary = Console.ReadLine();
            double number = 0;
            double pow = binary.Length - 1;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    number += Math.Pow(2, pow);
                }
                pow--;
            }

            Console.WriteLine(number);
        }
    }
}
