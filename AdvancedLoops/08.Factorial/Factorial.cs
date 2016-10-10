using System;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            do
            {
                fact = fact * n; //fact *= n;
                n--;
            } while (n>1);
            Console.WriteLine(fact);

        }
    }
}
