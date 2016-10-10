using System;
using System.Linq;

namespace TrippleSum
{
    class TrippleSum
    {
        static void Main()
        {
            //string input = Console.ReadLine();
            //string[] numbers = input.Split(' ');
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    int[] arr = numbers.Select(int.Parse).ToArray();
            //}
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    int a = nums[i];
                    int b = nums[j];
                    int sum = a + b;
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
