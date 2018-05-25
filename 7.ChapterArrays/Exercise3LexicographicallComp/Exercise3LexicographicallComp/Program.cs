using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3LexicographicallComp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter length of first word: ");
            char[] first = new char[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter your word in small letters:");
            for(int i = 0; i < first.Length; i++)
            {
                first[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.Write("Enter length of seccond word: ");
            char[] seccond = new char[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter your word in small letters:");
            for (int i = 0; i < seccond.Length; i++)
            {
                seccond[i] = Convert.ToChar(Console.ReadLine());
            }

            bool equal = true;
            bool isFirstFirst = false;
            int count = first.Length > seccond.Length ? seccond.Length : first.Length;
            
            for(int i = 0; i < count; i++)
            {
                if (first[i] != seccond[i])
                {
                    if (first[i] < seccond[i])
                    {
                        isFirstFirst = true;
                    }

                    break;
                }
            }

            if (equal)
            {
                if (first.Length < seccond.Length)
                {
                    isFirstFirst = true;
                    equal = false;
                }
                else if (first.Length > seccond.Length)
                {
                    isFirstFirst = false;
                    equal = false;
                }
            }

            if (equal)
            {
                Console.WriteLine("Array's are equal.");
            }
            else
            {
                Console.WriteLine(isFirstFirst ? "First word is first" : "Seccon word is first");
            }
        }
    }
}
