using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSelectedTextUperCase
{
    class Program
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string resultText = MakeTagsUpCase(text);

            Console.WriteLine(resultText);
        }

        private static string MakeTagsUpCase(string text)
        {

            int startTag = 0;
            int endTag = 0;

            startTag = text.IndexOf("<upcase>");
            endTag = text.IndexOf("</upcase>");

            while (startTag != -1)
            {
                string textToReplace = text.Substring(startTag + 8, (endTag - startTag - 8));
                text = text.Replace("<upcase>" + textToReplace + "</upcase>", textToReplace.ToUpper());

                startTag = text.IndexOf("<upcase>");
                endTag = text.IndexOf("</upcase>");
            }

            return text;
        }
    }
}
