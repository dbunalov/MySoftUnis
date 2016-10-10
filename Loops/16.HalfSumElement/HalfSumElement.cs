using System;

namespace _16.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }

            }
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(max - (sum-max)));
            }
        }
    }
}
