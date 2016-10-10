using System;
using System.Linq;

namespace SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len = Math.Max(firstArray.Length, secondArray.Length);
            var sumArrays = new int[len];
            for (int i = 0; i < len; i++)
            {
                sumArrays[i] = firstArray[i % firstArray.Length] + secondArray[i% secondArray.Length];//multiply arrays
            }
            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}
