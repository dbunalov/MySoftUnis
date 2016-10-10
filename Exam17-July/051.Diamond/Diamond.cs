using System;
namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cols = 5 * n;
            var rows = 3 * n + 2;
            Console.Write(new string('.', n));
            Console.Write(new string('*', cols - 2 * n));
            Console.WriteLine(new string('.', n));
            var mid = 3 * n;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', n - 1 - i));
                Console.Write('*');
                Console.Write(new string('.', mid));
                Console.Write('*');
                Console.WriteLine(new string('.', n - 1 - i));
                mid = mid + 2;
            }
            Console.WriteLine(new string('*', cols));
            for (int j = 1; j <= rows - n - 1; j++)
            {
                mid = cols - 2 - 2 * j;
                if (mid >= n - 2)
                {
                    Console.Write(new string('.', j));
                    Console.Write('*');
                    Console.Write(new string('.', mid));
                    Console.Write('*');
                    Console.WriteLine(new string('.', j));
                }
            }
            Console.Write(new string('.', 2 * n + 1));
            Console.Write(new string('*', n - 2));
            Console.WriteLine(new string('.', 2 * n + 1));
        }
    }
}