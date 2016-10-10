using System;

class FastPrimeChecker
{
    static void Main(string[] args)
    {
        int n = 2;
        int m = int.Parse(Console.ReadLine());
        for (int number = n; number <= m; number++)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            while (divider <= maxDivider)
            {
                if (number % divider == 0)
                {
                    prime = false;
                    Console.WriteLine($"{number} -> {prime}");
                    break;
                }
                divider++;

            }
            if (prime)
                Console.WriteLine($"{number} -> {prime}");
        }
    }
}