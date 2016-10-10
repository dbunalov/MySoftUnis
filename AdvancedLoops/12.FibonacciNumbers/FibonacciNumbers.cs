using System;

namespace _12.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            var f0 = 1;
            var f1 = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-1; i++)
            {
                var fibNext = f0 + f1;
                f0 = f1;
                f1 = fibNext;
            }
            Console.WriteLine(f1);
        }
    }
}
