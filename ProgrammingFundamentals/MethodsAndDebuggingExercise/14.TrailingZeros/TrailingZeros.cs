using System;
using System.Numerics;

namespace TrailingZeros
{
    public class TrailingZeros
    {
        public static BigInteger GetFactorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
        public static BigInteger GetTrailingZeros(BigInteger factoriel)
        {
            BigInteger fact = factoriel;
            string str = fact.ToString();
            string[] ss = str.Split('0');
            int countTrailingZeros = 0;
            for (int i = ss.Length - 1; i >= 0; i--)
            {
                if (ss[i] == "")
                    countTrailingZeros = countTrailingZeros + 1;
                else
                    break;
            }
           
            return countTrailingZeros;
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = GetFactorial(n);

            BigInteger trailingZeros = GetTrailingZeros(factoriel);
            Console.WriteLine(trailingZeros);
        }
    }
}
