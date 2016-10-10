using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> positive = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] > 0)
                    {
                        positive.Add(input[i]);
                    }                
            }
            if (positive.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positive));
            }
        }
    }
}
