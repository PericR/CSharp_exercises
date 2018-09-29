using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOREncription
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Test";
            string cipher = "ab";

            string result = XOREncription.DoXorEncription(cipher, test);
            Console.WriteLine(result);
        }
    }
}
