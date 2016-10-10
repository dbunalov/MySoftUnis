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
            for (int i = n; i >= 0; i--)
            {
                result = n * i;
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
