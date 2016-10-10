using System;

namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
