using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPalindromesInText
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            List<string> palindromes = ExtractPalindromes(text);

            foreach(string word in palindromes)
            {
                Console.WriteLine(word);
            }

        }

        static List<string> ExtractPalindromes(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach(string word in words)
            {
                word.Trim();
                if (IsWordPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            return palindromes;
        }

        static bool IsWordPalindrome(string word)
        {
            bool isPalindrome = true;

            for (int i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                if (word[i] != word[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
