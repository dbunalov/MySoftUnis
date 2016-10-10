using System;

namespace _18.EqualPairs
{
    class EqualPairs
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var firstNumber = 0;
            var secondNumber = 0;
            var sum = 0;
            var sum2 = 0;
            var diff = 1;
            var maxdiff = 0;

            for (int i = 1; i <= count; i++)
            {
                sum = sum2;
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                sum2 = firstNumber + secondNumber;
                diff = Math.Abs(sum2 - sum);
                if ((diff > maxdiff) && (i>=2)) 
                {
                    maxdiff = diff;
                }
            }
            if (maxdiff == 0)
            {
                Console.WriteLine("Yes, value = {0}", sum2);
            }
            
            else
            {
                Console.WriteLine("No, maxdiff = {0}", maxdiff);
            }
        }
    }
}
