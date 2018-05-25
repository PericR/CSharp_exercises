using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileParseException
{
    class Program
    {
        static void Main()
        {
            string path = @"..\..\Integers.txt";
            try
            {
                ReadIntegersFromFile(path);
            }
            catch(FileParseException FPException)
            {
                Console.WriteLine(FPException.Message + " at line " + FPException.Line + " in file " + FPException.FileName);
            }
            Console.WriteLine("Done");
        }

        static void ReadIntegersFromFile(string path)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int lineCount = 0;
                do
                {
                    int testInteger = 0;
                    lineCount++;

                    if (Int32.TryParse(line, out testInteger))
                    {
                        Console.WriteLine(line);
                    }
                    else
                    {
                        throw new FileParseException("Line does not contain integer.", path, lineCount);
                    }

                    line = reader.ReadLine();
                }
                while (line != null);
            }

        }
    }
}
