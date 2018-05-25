using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace ReadAllTextFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter path: ");
            string path = Console.ReadLine();
            string textFromFile = "";

            try
            {
                textFromFile = File.ReadAllText(path);
            }
            catch (ArgumentException argException)
            {
                Console.WriteLine("{0}\n{1}", argException.Message, argException.StackTrace);
            }
            catch (PathTooLongException PTLException)
            {
                Console.WriteLine("{0}\n\n{1}", PTLException.Message, PTLException.StackTrace);
            }
            catch(DirectoryNotFoundException DNFException)
            {
                Console.WriteLine("{0}\n\n{1}", DNFException.Message, DNFException.StackTrace);
            }
            catch(IOException IOException)
            {
                Console.WriteLine("{0}\n\n{1}", IOException.Message, IOException.StackTrace);
            }
            catch(UnauthorizedAccessException UAException)
            {
                Console.WriteLine("{0}\n\n{1}", UAException.Message, UAException.StackTrace);
            }
            catch(NotSupportedException NSException)
            {
                Console.WriteLine("{0}\n\n{1}", NSException.Message, NSException.StackTrace);
            }
            catch(SecurityException SeExcepton)
            {
                Console.WriteLine("{0}\n\n{1}", SeExcepton.Message, SeExcepton.StackTrace);
            }


            Console.WriteLine(textFromFile);
        }
    }
}
