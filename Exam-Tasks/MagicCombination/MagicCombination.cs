using System;

namespace MagicCombination
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                n = 1;
            }
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                for (int f = 0; f <= 9; f++)
                                {
                                    //if (a * n == n && b * n == n && c * n == n && d*n ==n && e * n == n && f*n == n)
                                    if (a * b * c * d * e * f == n)
                                    {
                                        Console.Write($"{a}{b}{c}{d}{e}{f} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
