using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int r = 0; r < nums.Length - 1; r++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }
            }
            Console.WriteLine(nums[0]);

            //while (nums.Length >= 2) // condensing
            //{
            //    var result = new int[nums.Length - 1];//shrink array
            //    for (int i = 0; i < nums.Length - 1; i++)
            //    {
            //        result[i] = nums[i] + nums[i + 1];
            //    }
            //    nums = result;
            //}
            //Console.WriteLine(nums[0]);
        }
    }
}
