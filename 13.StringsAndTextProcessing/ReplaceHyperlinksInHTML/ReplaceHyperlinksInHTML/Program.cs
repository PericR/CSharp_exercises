using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceHyperlinksInHTML
{
    class Program
    {
        static void Main()
        {
            string html = "<p>Please visit <a href=\"http://softuni.org\">our site</a> to choose a training course. Also visit <a href=\"http://forum.softuni.org\">our forum</a> to discuss the courses.</p>";
            string resultHtml = html.Replace("<a href=\"", "[URL=");
            resultHtml = resultHtml.Replace("</a>", "[/URL]");
            resultHtml = resultHtml.Replace("\">", "]");

            Console.WriteLine(resultHtml);
        }
    }
}
