using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParseException
{
    /// <summary>
    /// Exception for dealing with files containing integers
    /// </summary>
    class FileParseException : Exception
    {
        private string fileName;
        private int line;

        public FileParseException(string message, string fileName, int line)      
            : base (message)      
        {
            this.fileName = fileName;
            this.line = line;
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }
        }

        public int Line
        {
            get
            {
                return this.line;
            }
        }
    }
}
