using System;

namespace _07.LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < count; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < count; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum-rightSum));
            }
        }
    }
}
