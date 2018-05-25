using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12CalcNumeralExpre
{
    /// <summary>
    /// Operator represents mathemathical operators along with its precedence and associativity
    /// </summary>
    struct Operator
    {       
        private char simbol;
        private int precedence;
        private char associativity;

        public Operator(char simbol, int precedence, char associativity)
        {
            this.simbol = simbol;
            this.precedence = precedence;
            this.associativity = associativity;
        }

        public Operator(char simbol)
        {
            this.simbol = simbol;
            this.precedence = 0;
            this.associativity = 'N';
        }

        public char Simbol
        {
            get
            {
                return simbol;
            }            
        }

        public int Precedence
        {
            get
            {
                return precedence;
            }
        }

        public char Associativity
        {
            get
            {
                return associativity;
            }
        }
    }
}
