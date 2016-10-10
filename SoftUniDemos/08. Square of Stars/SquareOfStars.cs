using System;


namespace _08.Square_of_Stars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (var i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("*"+ new string(' ', n - 2) + "*");
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
