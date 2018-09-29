using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsAndExplanationsDictionary
{
    public class WordDictionary
    {
        private Dictionary<string, string> wordsWithExplanations = new Dictionary<string, string>();

        public void AcceptNewEntrys(string entrys)
        {
            string[] parsedEntrys = entrys.Split('\n');

            foreach(string entry in parsedEntrys)
            {
                AddNewEntry(entry);
            }
        }

        private void AddNewEntry(string entry)
        {
            entry = entry.ToLower();
            string[] parsed = entry.Split('–');
            wordsWithExplanations.Add(parsed[0].Trim(), parsed[1].Trim());
        }

        public string CheckGivenWord(string word)
        {
            string explanation;
            bool isRightKey = wordsWithExplanations.TryGetValue(word, out explanation);

            if (!isRightKey)
            {
                explanation = "Word is not in dictionary.";
            }

            return explanation;
        }
    }
}
