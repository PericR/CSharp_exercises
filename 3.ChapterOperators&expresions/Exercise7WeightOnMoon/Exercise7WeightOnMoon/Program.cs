using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7WeightOnMoon
{
    class WeightOnMoon
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight in kilograms on Earth: ");
            float weight = float.Parse(Console.ReadLine());
            float weightOnMoon = weight * 0.17f;

            Console.WriteLine("{0} kg is {1} kg on moon.", weight, weightOnMoon);
        }
    }
}
