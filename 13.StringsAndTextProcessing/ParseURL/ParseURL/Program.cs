using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"https://www.fpmoz.ba/pdf/uvoduof.pdf";
            string[] parsed = ParseUrl(url);

        }

        static string[] ParseUrl(string url)
        {
            string[] parsed = new string[3];
            int index = url.IndexOf(@"//");
            int index2 = url.LastIndexOf('/');
            parsed[0] = url.Substring(0, index);
            parsed[1] = url.Substring(index + 2, index2 - index - 2);
            parsed[2] = url.Substring(index2 + 1);

            return parsed;
        }
    }
}
