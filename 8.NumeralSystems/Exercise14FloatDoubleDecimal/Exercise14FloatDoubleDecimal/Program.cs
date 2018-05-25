using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;

            for(int i = 0; i < 50000000; i++)
            {
                sum += 0.000001f;
            }

            Console.WriteLine(sum);


            decimal sumDec = 0;

            for (int i = 0; i < 50000000; i++)
            {
                sumDec += 0.000001m;
            }

            Console.WriteLine(sumDec);

            double sumD = 0;

            for (int i = 0; i < 50000000; i++)
            {
                sumD += 0.000001;
            }

            Console.WriteLine(sumD);
        }
    }
}
