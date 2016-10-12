using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> wordsByCount = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (wordsByCount.ContainsKey(input[i]))
                {
                    wordsByCount[input[i].ToLower()] += 1;
                }
                else
                {
                    wordsByCount[input[i]] = 1;
                }
            }
            List<string> words = new List<string>();
            foreach (string word in wordsByCount.Keys)
            {
                if (wordsByCount[word] % 2 == 1)
                {
                    words.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
