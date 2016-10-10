using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length + 1; i++)
            {
                nums[i] = nums[(i + k) % nums.Length];
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}