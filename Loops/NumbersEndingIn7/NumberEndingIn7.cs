using System;

namespace NumbersEndingIn7
{
    class NumberEndingIn7
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 1000; number++)
            {
                if (number % 10 == 7)
                {
                    Console.WriteLine(number);
                }

            }
        }
    }
}
