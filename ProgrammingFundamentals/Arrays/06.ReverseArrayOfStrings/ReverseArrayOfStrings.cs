using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main()
        {
           // string[] items = Console.ReadLine().Split(' ').ToArray();

            //var reversedItems = items.Reverse(); // easy way
            //Console.WriteLine(string.Join(" ", reversedItems));

            //second way :)

            //var result = new string[items.Length];
            //for (int i = 0; i < items.Length; i++)
            //{
            //    result[items.Length - i - 1] = items[i];
            //}
            //Console.WriteLine(string.Join(" ", result));

            // third way :D

            //for (int i = 0; i < items.Length / 2; i++)
            //{
            //    var old = items[i];
            //    items[i] = items[items.Length - 1 - i];
            //    items[items.Length - 1 - i] = old;
            //}
            //Console.WriteLine(string.Join(" ", items));

            //functional style
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse())); 
        }
    }
}
