using System;

class RectangleWithStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int lines = n % 2 == 1 ? n : n - 1;

        Console.WriteLine(new string('%', n * 2));
        for (int i = 0; i < lines; i++)
        {
            Console.Write("%");
            if (i == lines / 2)
            {
                Console.Write(new string(' ', n - 2));
                Console.Write("**");
                Console.Write(new string(' ', n - 2));
            }
            else
            {
                Console.Write(new string(' ', n * 2 - 2));
            }
            
            Console.Write("%");
            Console.WriteLine();
        }
        Console.WriteLine(new string('%', n * 2));
    }
}