using System;
using System.Collections.Generic;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            string[] numbersAsString = Console.ReadLine().Split(' ');
            double[] numbers = new double[numbersAsString.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(numbersAsString[i]);
            }

            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dict.ContainsKey(numbers[i]))
                {
                    dict[numbers[i]] += 1;
                }
                else
                {
                    dict[numbers[i]] = 1;
                }
            }
            foreach (double num in dict.Keys)
            {
                Console.WriteLine($"{num} -> {dict[num]}");
            }
        }
    }
}
