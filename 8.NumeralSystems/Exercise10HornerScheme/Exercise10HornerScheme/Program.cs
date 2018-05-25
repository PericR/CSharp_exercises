using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10HornerScheme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            int decimalNumber = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                int current = Convert.ToInt32(binary[i].ToString());
                decimalNumber = (decimalNumber * 2) + current;
            }

            Console.WriteLine("{0} in binary is {1} in decimal.", binary, decimalNumber);
        }
    }
}
