using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintName(name);
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
