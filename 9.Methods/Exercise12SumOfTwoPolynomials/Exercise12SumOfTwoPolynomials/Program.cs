using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12SumOfTwoPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polynomial = new int[10];

            Console.WriteLine("Enter first polynomial (e.g. +3x3 -4x2 -2x1 +4x0): ");
            string polynomialString = Console.ReadLine();
            MakePolynomialInArray(polynomialString, polynomial);

            Console.WriteLine("Enter seccond polynomial (e.g. +3x3 -4x2 -2x +4): ");
            polynomialString = Console.ReadLine();
            MakePolynomialInArray(polynomialString, polynomial);

            Console.WriteLine(PrintResult(polynomial));
        }

        static void MakePolynomialInArray(string polynomialString, int[] polynomial)
        {
            string[] strArray = polynomialString.Split(' ');            

            foreach(string str in strArray)
            {
                string[] current = str.Split('x', 'X');
                polynomial[Convert.ToInt32(current[1])] += Convert.ToInt32(current[0]);
            }
        }

        static string PrintResult(int[] polynomial)
        {
            string result = "";

            for(int i = 0; i < 10; i++)
            {
                int value = polynomial[i];

                if (value == 0)
                {
                    continue;
                }

                result = value + "x" + i + " " + result;
            }

            return result;
        }
    }
}
