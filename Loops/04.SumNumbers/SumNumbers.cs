using System;

namespace _04.SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());
            var sum = 0; // to sum use = 0, to multiply use = 1;

            for (int i = 0; i < numberCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;//sum = sum + currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
