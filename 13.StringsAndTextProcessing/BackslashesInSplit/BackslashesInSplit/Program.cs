using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackslashesInSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"one\two\three";
            string[] strArr=str.Split('\\');

            foreach(string s in strArr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
