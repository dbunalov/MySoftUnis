using System;
using System.Collections.Generic;
using System.Linq;


namespace Tester
{
    class Tester
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


            /////
            //var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //SortedDictionary<double, int> dic = new SortedDictionary<double, int>();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (dic.ContainsKey(input[i]))
            //    {
            //        dic[input[i]] += 1;
            //    }
            //    else
            //    {
            //        dic[input[i]] = 1;
            //    }
            //}
            //foreach (KeyValuePair<double, int> num in dic) // first way
            //{
            //    Console.WriteLine($"{num.Key} -> {num.Value}");
            //}

            ////foreach (double num in dic.Keys) // second way (both almost the same with upper one)
            ////{
            ////    Console.WriteLine($"{num} -> {dic[num]}");
            ////}

        }
    }
}
