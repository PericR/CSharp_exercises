using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSentencesWithParticularWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] result = ExtractSentencesByGivenWord(text, "in");
        }

        private static string[] ExtractSentencesByGivenWord(string text, string chosenWord)
        {
            string[] allSentences = text.Split('.');
            List<string> chosenSentences = new List<string>();

            foreach(string sentence in allSentences)
            {
                int chosenWordPosition = -1;
                do
                {
                    chosenWordPosition = sentence.IndexOf(chosenWord, chosenWordPosition + 1);

                    if (chosenWordPosition > 0 && sentence[chosenWordPosition - 1] == ' ')
                    {
                        if (sentence.Length == chosenWordPosition + chosenWord.Length || sentence[chosenWordPosition + chosenWord.Length] == ' ' || sentence[chosenWordPosition + chosenWord.Length] == '.' || sentence[chosenWordPosition + chosenWord.Length] == ',' || sentence[chosenWordPosition + chosenWord.Length] == '!' || sentence[chosenWordPosition + chosenWord.Length] == '?')
                        {
                            chosenSentences.Add(sentence);
                            break;
                        }
                    }
                    else if (chosenWordPosition == 0)
                    {
                        if (sentence[chosenWordPosition + chosenWord.Length] == ' ' || sentence[chosenWordPosition + chosenWord.Length] == '.' || sentence[chosenWordPosition + chosenWord.Length] == ',' || sentence[chosenWordPosition + chosenWord.Length] == '!' || sentence[chosenWordPosition + chosenWord.Length] == '?')
                        {
                            chosenSentences.Add(sentence);
                            break;
                        }
                    }

                } while (chosenWordPosition != -1);
            }

            return chosenSentences.ToArray();
        }
    }
}
