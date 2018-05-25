using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            double decimalNumb = 0;

            for (int i = 0, j = binary.Length - 1; i < binary.Length; i++, j--)
            {
                string ch = binary[i].ToString();
                int curent = Convert.ToInt32(ch);
                decimalNumb = decimalNumb + (curent * Math.Pow(2, j));
            }

            Console.WriteLine("{0} in binary is {1} in decimal", binary, decimalNumb);
        }
    }
}
