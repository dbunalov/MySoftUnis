using System;

namespace MaxMethod
{
    public class MaxMethod
    {
        public static int GetMax(int a, int b)
        {
            int biggerValue = Math.Max(a, b);
            return biggerValue;
        }
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirtNumber = int.Parse(Console.ReadLine());
            int tempBiggerValue = GetMax(firstNumber, secondNumber);
            int result = GetMax(tempBiggerValue, thirtNumber);

            Console.WriteLine(result);
        }
    }
}
