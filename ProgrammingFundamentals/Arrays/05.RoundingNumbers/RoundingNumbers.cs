using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            foreach (var num in nums)
            {
                var rounded = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine(num + " => " + rounded);
            }
        }
    }
}
