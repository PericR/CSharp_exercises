using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToUnicodeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Test";

            test = ConvertStringToUnicodeArray(test);
            Console.WriteLine(test);
        }

        private static string ConvertStringToUnicodeArray(string text)
        {
            char[] textChars = text.ToCharArray();
            StringBuilder temporaryText = new StringBuilder();

            for(int i = 0; i < textChars.Length; i++)
            {
                ushort charNumber = textChars[i];

                temporaryText.Append(String.Format("\\u{0:x4}", charNumber));
            }

            return temporaryText.ToString();
        }
    }
}
