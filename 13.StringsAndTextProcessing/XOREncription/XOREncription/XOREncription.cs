using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOREncription
{
    static class XOREncription
    {
        public static string DoXorEncription(string cipher, string text)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                ushort textLetterNumber = text[i];
                ushort cipherLetterNumber = cipher[i % cipher.Length];

                int resultLetterNumber = textLetterNumber ^ cipherLetterNumber;
                result.Append(String.Format("\\u{0:x4}", resultLetterNumber));
            }

            return result.ToString();
        }
    }
}
