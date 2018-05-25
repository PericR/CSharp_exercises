using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15MantissaOfFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            float number = float.Parse(Console.ReadLine());
            byte[] numberBinary = System.BitConverter.GetBytes(number);

            string floatingPointPrecision = "";

            foreach (byte by in numberBinary)
            {
                string temp = Convert.ToString(by, 2).PadLeft(8, '0');
                floatingPointPrecision = temp + floatingPointPrecision;
            }

            string sign = floatingPointPrecision.Substring(0, 1);
            string exponent = floatingPointPrecision.Substring(1, 8);
            string mantissa = floatingPointPrecision.Substring(9);

            Console.WriteLine("sign: {0}\nExponent: {1}\nMantissa: {2}", sign, exponent, mantissa);
        }
    }
}
