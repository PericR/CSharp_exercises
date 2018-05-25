using System;
using System.Text;
using System.IO;
namespace TextFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            Console.WriteLine(ReadTextFile(path));
        }

        static string ReadTextFile(string path)
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader reader = new StreamReader(path))
            {
                string line = ".";
                while (!string.IsNullOrEmpty(line))
                {
                    line = reader.ReadLine();
                    text = text.AppendLine(line);
                }
            }
            return text.ToString();
        }
    }
}
