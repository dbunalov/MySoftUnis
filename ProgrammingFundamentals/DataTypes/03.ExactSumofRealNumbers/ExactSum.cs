using System;

class ExactSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal exactSum = 0;
        for (int i = 1; i <= n; i++)
        {
            decimal numb = decimal.Parse(Console.ReadLine());

            exactSum += numb;

        }
        Console.WriteLine(exactSum);
    }
}