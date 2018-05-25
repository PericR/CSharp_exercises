using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13MultiplyTwoPolynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            Monomial[] first = new Monomial[10];
            Monomial[] seccond = new Monomial[10];
            Monomial[] result = new Monomial[10];

            Console.Write("Enter first polynomial: ");
            string stringPolynomial = Console.ReadLine();
            FillPolynomial(first, stringPolynomial);

            Console.Write("Enter seccond polynomial: ");
            stringPolynomial = Console.ReadLine();
            FillPolynomial(seccond, stringPolynomial);

            MultiplyPolynomials(first, seccond, result);

            Console.WriteLine("({0}) * ({1}) = {2}", ConvertPolynomialToString(first), ConvertPolynomialToString(seccond), ConvertPolynomialToString(result));
        }

        static void FillPolynomial(Monomial[] polynomial, string stringPolynomial)
        {
            string[] strPoly = stringPolynomial.Split(' ');

            foreach(string str in strPoly)
            {
                string[] current = str.Split('x', 'X');
                int value = int.Parse(current[0]);
                int exponent = int.Parse(current[1]);

                polynomial[exponent] = new Monomial(value, exponent);
            }
        }

        static void MultiplyPolynomials(Monomial[] first, Monomial[] seccond, Monomial[] result)
        {
            for(int i = 0; i < 10; i++)
            {
                if (first[i] == null)
                {
                    continue;
                }

                for(int j = 0; j < 10; j++)
                {
                    if (seccond[j] == null)
                    {
                        continue;
                    }

                    int exponent = first[i].Exponent + seccond[j].Exponent;
                    int value = first[i].Value * seccond[j].Value;

                    if (result[exponent] == null)
                    {
                        result[exponent] = new Monomial(value, exponent);
                    }
                    else
                    {
                        result[exponent].Value += value;
                    }
                }
            }
        }

        static string ConvertPolynomialToString(Monomial[] polynomial)
        {
            string strPolynomial = "";

            for(int i = 0; i < 10; i++)
            {
                if (polynomial[i] == null)
                {
                    continue;
                }

                strPolynomial = polynomial[i].Value + "x" + polynomial[i].Exponent + " " + strPolynomial;
            }

            return strPolynomial;
        }
    }
}
