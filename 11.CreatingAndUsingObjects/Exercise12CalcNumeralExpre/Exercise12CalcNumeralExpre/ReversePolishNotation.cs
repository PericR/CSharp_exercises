using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12CalcNumeralExpre
{
    /// <summary>
    /// Class contains methods for converting to and calculating Reversed Polish Notation
    /// </summary>
    public static class ReversedPolishNotation
    {
        private static Operator plus = new Operator('+', '2', 'L');
        private static Operator minus = new Operator('-', '2', 'L');
        private static Operator multyple = new Operator('*', '3', 'L');
        private static Operator division = new Operator('/', '3', 'L');
        private static Operator pow = new Operator('^', '4', 'R');
        private static Operator sqrt = new Operator('s', '4', 'R');
        private static Operator ln = new Operator('l', '4', 'R');
        private static Operator leftBracet = new Operator('(');
        private static Operator rightBracet = new Operator(')');

        /// <summary>
        /// Converts math expreson to Reversed Polish Notation
        /// </summary>
        /// <param name="expresion">Represents expresion as array of strings, where each index represents one expreson member</param>
        /// <returns>Returns Reversed Polish Notation as string</returns>
        public static string ConvertToRPN(string[] expresion)
        {
            string result = "";
            Stack<Operator> operatorStack = new Stack<Operator>();
            double currentNumber = 0;

            foreach(string token in expresion)
            {

                if (double.TryParse(token, out currentNumber))
                {
                    result = result + " " + currentNumber;
                }
                else if (CheckIfOperator(token))
                {
                    result = result + ProccesOperator(token, operatorStack);                    
                }
                else if (token == "(")
                {                    
                    operatorStack.Push(leftBracet);
                }
                else if (token == ")")
                {
                    result = result + ProccesRightBracet(operatorStack);
                }
                else
                {
                    Console.WriteLine("Current token is not suported operator or number," +
                        " input expresion is probably wrong!");
                    break;
                }
            }

            while (operatorStack.Count > 0)
            {
                result = result + " " + operatorStack.Pop().Simbol;
            }

            return result;
        }
        
        /// <summary>
        /// Method check if current member of expresoin is operand or one of supported functons
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private static bool CheckIfOperator(string token)
        {
            bool isOperator = false;
            if (token == "+" || token == "-" || token == "*" || token == "/" || token == "ln" || token == "sqrt" || token == "pow")
            {
                isOperator = true;
            }

            return isOperator;
        }
        
        /// <summary>
        /// Checks what operator is currently selected
        /// </summary>
        /// <param name="token">Operator as a string</param>
        /// <returns>Returns operator as Operator struct</returns>
        private static Operator CheckOperator(string token)
        {
            Operator current = new Operator('N');

            if (token == "+")
            {
                current = plus;
            }
            else if (token == "-")
            {
                current = minus;
            }
            else if (token == "*")
            {
                current = multyple;
            }
            else if (token == "/")
            {
                current = division;
            }
            else if (token == "pow")
            {
                current = pow;
            }
            else if (token == "ln")
            {
                current = ln;
            }
            else if (token == "sqrt")
            {
                current = sqrt;
            }

            return current;
        }

        /// <summary>
        /// Procces operator based on the current state of the operatorStack and current operator
        /// </summary>
        /// <param name="token">Operator as string</param>
        /// <param name="operatorStack">operatorStack contains operators proccesed till now</param>
        /// <returns>Returns string as current result</returns>
        private static string ProccesOperator(string token, Stack<Operator> operatorStack)
        {
            Operator current = CheckOperator(token);
            string result = "";

            if (operatorStack.Count != 0)
            {                
                while ((operatorStack.Peek().Precedence > current.Precedence) ||
                (operatorStack.Peek().Precedence == current.Precedence && current.Associativity == 'L' &&
                operatorStack.Peek().Simbol != '('))
                {
                    result = result + " " + operatorStack.Pop().Simbol;
                    if (operatorStack.Count == 0)
                    {
                        break;
                    }
                }
            }

            operatorStack.Push(current);
            return result;
        }
        
        private static string ProccesRightBracet(Stack<Operator> operatorStack)
        {
            string result = "";

            while (operatorStack.Peek().Simbol != '(')
            {
                result = result + " " + operatorStack.Pop().Simbol;
            }

            operatorStack.Pop();
            return result;
        }

        /// <summary>
        /// Method calculate Reversed Polish Notation expresion
        /// </summary>
        /// <param name="expresion">Expresion string represented in Reversed Polish Notation</param>
        /// <returns>Returs result as string</returns>
        public static double CalculateRPN(string expresion)
        {
            string[] tokens = expresion.Split(' ');
            Stack<string> numbers = new Stack<string>();
            double current = 0;

            foreach (string token in tokens)
            {
                if(double.TryParse(token, out current))
                {
                    numbers.Push(current.ToString());
                }
                else if (token == "+" || token == "-" || token == "*" || token == "/" || token=="^")
                {
                    double b = double.Parse(numbers.Pop());
                    double a = double.Parse(numbers.Pop());
                    numbers.Push(CalculateWithTwoOperands(token, a, b).ToString());
                }
                else if (token == "l" || token == "s")
                {
                    double a = double.Parse(numbers.Pop());
                    numbers.Push(CalculateWithOneOperand(token, a).ToString());
                }
                else
                {
                    Console.WriteLine("Something in your expresion is wrong, please reevaluate it!");
                    break;
                }
            }

            return double.Parse(numbers.Pop());
        }

        /// <summary>
        /// Calculate when token uses two operands
        /// </summary>
        private static double CalculateWithTwoOperands(string token, double a, double b)
        {
            double result = 0;

            if (token == "+")
            {
                result = a + b;
            }
            else if (token == "-")
            {
                result = a - b;
            }
            else if (token == "*")
            {
                result = a * b;
            }
            else if (token == "/")
            {
                result = a / b;
            }
            else if (token == "^")
            {
                result = Math.Pow(b, a);
            }

            return result;
        }

        /// <summary>
        /// Calculates when token uses one operand
        /// </summary>        
        private static double CalculateWithOneOperand(string token, double a)
        {
            double result = 0;

            if (token == "l")
            {
                result = Math.Log(a);
            }
            else if (token == "s")
            {
                result = Math.Sqrt(a);
            }

            return result;
        }
    }
}
