using System;

class Axe
{
	static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {            
            Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3),new string('-',i-1),new string('-',(5*n) - 2 - (3*n) - (i-1)));
        }
        for (int j = 1; j <= n-3; j++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('*', n * 3), new string('-', n -1), new string('-', (n-1)));
        }
        Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3),new string('-',n-1),new string('-',n-1));

        Console.WriteLine("{0}**{1}**{2}", new string('-', n * 3-1), new string('*', n - 1), new string('-', (n - 2)));

    }
}
