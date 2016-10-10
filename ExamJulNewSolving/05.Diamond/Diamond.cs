using System;

class Diamond
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n*3));//first line

        for (int i = n-1; i > 0; i--)//upper body
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 5 * n - 2 - 2 * i));
        }
        Console.WriteLine("{0}", new string('*', 5*n));//middle line

        for (int i = 1; i <= n * 2; i++)//down body
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 5 * n - 2 - 2 * i));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n * 2 + 1), new string('*', n-2));
    }
}