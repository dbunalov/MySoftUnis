using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> nums = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                nums.Add(int.Parse(input[i]));
            }
            
            nums.Sort();
            var possition = 0;
            while (possition < nums.Count)
            {
                int num = nums[possition], count = 1;
                while (possition + count < nums.Count && nums[possition + count] == num)             
                {
                    count++;
                }
                possition = possition + count;
                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
