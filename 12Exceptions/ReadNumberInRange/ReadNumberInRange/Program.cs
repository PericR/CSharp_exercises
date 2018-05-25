using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for(int i = 0; i < 10;)
            {
                try
                {
                    numbers[i] = ReadNumber(1, 100);
                    i++;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message + "\nInvalid number");
                }
            }
        }

        public static int ReadNumber(int start, int end)
        {
            int number = 0;
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());

                if (number > end || number < start)
                {
                    throw new Exception("Number was outside given range.");
                }                
                            
            return number;
        }
    }
}
