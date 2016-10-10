using System;

namespace _09.SumDigits
{
    class SumDigits
    {
        static void Main()
        {

            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            while (num > 0)
            {
                var lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
