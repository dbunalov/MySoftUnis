using System;

namespace _08.Sunglases
{
    class Sunglases
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            for (int i = 0; i < n -2; i++)
            {
                bool isMiddle = false;
                Console.Write("*");
                Console.Write(new string('/', n*2-2));
                Console.Write("*");
                if (n % 2 == 0)
                {
                    if (i == (n - 2) / 2 - 1)
                    {
                        isMiddle = true;
                        Console.Write(new string('|', n));
                    }
                }
                else
                {
                    if (i == (n - 2) / 2)
                    {
                        isMiddle = true;
                        Console.Write(new string('|', n));
                    }
                }

                if (!isMiddle)
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

        }
    }
}
