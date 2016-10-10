using System;

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var minNumber = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
