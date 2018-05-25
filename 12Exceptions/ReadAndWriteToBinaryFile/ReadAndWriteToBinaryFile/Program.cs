using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAndWriteToBinaryFile
{
    class Program
    {
        static void Main()
        {
            string filePath = @"..\..\zz.zip";
            
            byte[] fileInBytes = ReadBinaryFile(filePath);
            WriteFromBinaryFile(fileInBytes, "new.zip");
                        
            Console.WriteLine("done");
        }

        /// <summary>
        /// Reads all bytes from some file
        /// </summary>
        /// <param name="fileName">Path to the file</param>
        /// <returns></returns>
        public static byte[] ReadBinaryFile(string fileName)
        {
            byte[] bytes;
            using (FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[reader.Length];
                int offset = 0;
                int sizeToRead = 64;
                int currentlyReadedBytes = 0;

                do
                {
                    currentlyReadedBytes = reader.Read(bytes, offset, sizeToRead);
                    offset += sizeToRead;

                    if (offset + sizeToRead >= reader.Length)
                    {
                        sizeToRead = (int)(reader.Length - offset);
                    }
                }
                while (sizeToRead > 0);
            }
            return bytes;
        }

        /// <summary>
        /// Makes new zip file using aray of bytes
        /// </summary>
        /// <param name="fileAsBytes">array of bytes</param>
        /// <param name="fileName">name for new file</param>
        public static void WriteFromBinaryFile(byte[] fileAsBytes,string fileName)
        {
            int offset = 0;
            int sizeToWrite = 64;

            using (FileStream writer = new FileStream(@"..\..\" + fileName, FileMode.Create, FileAccess.ReadWrite))
            {
                do
                {
                    writer.Write(fileAsBytes, offset, sizeToWrite);
                    offset += sizeToWrite;

                    if (offset + sizeToWrite >= fileAsBytes.Length)
                    {
                        sizeToWrite = fileAsBytes.Length - offset;
                    }
                }
                while (sizeToWrite > 0);
            }
        }
    }
}
