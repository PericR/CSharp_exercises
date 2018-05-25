using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7NamespaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatingAndUsingObjects.Cat johny = new CreatingAndUsingObjects.Cat("johny", "black");
            johny.SayMiau();

            Console.Write(CreatingAndUsingObjects.Sequence.NextValue());
        }
    }
}
