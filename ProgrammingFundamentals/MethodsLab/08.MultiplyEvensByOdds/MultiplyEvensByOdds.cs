using System;

namespace MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEven = GetSumOfEvenDigits(n);
            int sumOdd = GetSumOfOddDigits(n);
            return sumEven * sumOdd;
        }

        public static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum+= lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        public static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum+= lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = GetMultipleOfEvensAndOdds(Math.Abs(n));
            
            Console.WriteLine(sum);
        }
    }
}