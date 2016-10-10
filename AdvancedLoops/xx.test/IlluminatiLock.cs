using System;

class IlluminatiLock
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//always ODD

        //first row

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));//first row (using it for last also!)
        Console.WriteLine("{0}###{0}###{0}", new string('.', n-2));

        for (int rows = 0; rows < n/2-1; rows++)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", 
                new string('.', (n-4)-2*rows),
                new string('.', 2 + 2 * rows),
                new string('.', n-2));
        }

        for (int rows = 0; rows < n/2-1; rows++)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", 
                new string('.', (1 + (2 * rows))),
                new string('.', (n - 3) - 2 * rows),
                new string('.', n - 2));
        }
        Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));//first row (using it for 

    }
}