using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13MultiplyTwoPolynomial
{
    public class Monomial
    {
        private int value;
        private int exponent;

        public Monomial(int value, int exponent)
        {
            this.value = value;
            this.exponent = exponent;
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public int Exponent
        {
            get
            {
                return exponent;
            }            
        }
    }
}
