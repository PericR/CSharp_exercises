using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise14PrintHardDiscFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            TraverseDirectory("C:\\");
        }

        static void TraverseDirectory(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath), "");
        }

        static void TraverseDir(DirectoryInfo dir,string spaces)
        {
            List<DirectoryInfo> children = new List<DirectoryInfo>();

            Console.WriteLine(spaces + dir.FullName);
            try
            {
                children = dir.GetDirectories().ToList<DirectoryInfo>();
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Can't access: " + dir.FullName);
            }

            foreach (DirectoryInfo child in children)
            {
                TraverseDir(child, "   ");
            }
        }
    }
}
