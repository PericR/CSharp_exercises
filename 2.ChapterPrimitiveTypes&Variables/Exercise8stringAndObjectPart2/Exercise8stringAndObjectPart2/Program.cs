using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8stringAndObjectPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            string world = "World";
            object helloWorld = hello + world;
            string helloWorldString = (string)helloWorld;

            Console.WriteLine(helloWorldString);
        }
    }
}
