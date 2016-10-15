using System;
using System.Collections.Generic;
using System.Linq;


namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length); //the way to swap places RANDOM in array
                string temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
