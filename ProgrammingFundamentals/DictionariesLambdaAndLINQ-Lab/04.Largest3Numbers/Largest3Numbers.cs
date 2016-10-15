using System;
using System.Collections.Generic;
using System.Linq;


namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main()
        {
            //You can use LINQ query like this: nums.OrderByDescending(x => x).Take(3).
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> sortedNumbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                sortedNumbers.Add(input[i]);
            }
            sortedNumbers = sortedNumbers.OrderByDescending(num => num).Take(3).ToList();
            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}
