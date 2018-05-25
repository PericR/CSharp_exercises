using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12CalcNumeralExpre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expresion: ");
            string input = Console.ReadLine();
            string[] expresion = input.Split(' ');

            string ReversedPolish = ReversedPolishNotation.ConvertToRPN(expresion);
            ReversedPolish = ReversedPolish.Trim();
            Console.WriteLine(ReversedPolish);
            Console.WriteLine(ReversedPolishNotation.CalculateRPN(ReversedPolish));
        }
    }
}
