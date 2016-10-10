using System;
using System.Numerics;

namespace Factorial
{
    public class Factorial
    {
        public static BigInteger GetFactorial(int n)
        {
            BigInteger result = 1;
            //5 ! = 5 × 4 × 3 × 2 × 1 = 120
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = GetFactorial(n);
            Console.WriteLine(result);
        }
    }
}
