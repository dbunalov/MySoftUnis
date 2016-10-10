using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static int[] ExtractMiddElements(int[] nums)
        {

            int len = nums.Length;
            if (len == 1)
                return nums;
            if (len % 2 == 0)
                return new int[] { nums[len / 2 - 1], nums[len / 2] };
            return new int[] { nums[len / 2 - 1], nums[len / 2], nums[len / 2+1] };
            
        }
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = ExtractMiddElements(nums);
            Console.WriteLine("{ "+string.Join(", ", result)+" }");
        }
    }
}
