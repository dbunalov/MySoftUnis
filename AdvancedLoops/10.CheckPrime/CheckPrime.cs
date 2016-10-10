using System;

namespace _10.CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var isPrime = true;

            if (number % 2 == 0 || number == 1 || number <= 0)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(number); i+=2)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

           

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
