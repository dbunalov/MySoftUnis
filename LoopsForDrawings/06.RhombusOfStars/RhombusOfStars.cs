using System;

namespace _06.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n-1 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++) // stars
                {
                    
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n - i; j++) // stars
                {

                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
