using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise8Cat10.CreatingAndUsingObjects;

namespace Exercise8Cat10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[10];
          
            for(int i = 0; i < 10; i++)
            {
                cats[i] = new Cat("Cat" + Sequence.NextValue(), "");
            }

            foreach(Cat cat in cats)
            {
                cat.SayMiau();
            }
        }
    }
}
