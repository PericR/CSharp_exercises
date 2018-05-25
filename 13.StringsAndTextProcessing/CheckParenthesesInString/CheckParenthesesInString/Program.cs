using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckParenthesesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Parentheses in your string are placed corectly? {0}", CheckParenthesesInString(str));

        }

        static bool CheckParenthesesInString(string str)
        {
            bool isCorrectParentheses = false;
            int parenthesesCounter = 0;

            foreach (char ch in str)
            {
                if (ch == '(')
                {
                    parenthesesCounter++;
                    continue;
                }

                if (ch == ')')
                {
                    parenthesesCounter--;

                    if (parenthesesCounter < 0)
                    {
                        break;
                    }
                }
            }

            if (parenthesesCounter == 0)
            {
                isCorrectParentheses = true;
            }

            return isCorrectParentheses;
        }
    }
}
