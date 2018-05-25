using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFileFromInternet
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient downloader = new WebClient();
            downloader.DownloadFile(@"http://peric.site88.net/web_projekt/slike/zaglavlje.jpg", @"picture.jpg");
        }
    }
}
