using System;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (var num1 = 1; num1 <= n; num1++)
            {
                for (var num2 = 1; num2 <= n; num2++)
                {
                    for (var char1 = 'a'; char1 < 'a'+l; char1++)
                    {
                        for (var char2 = 'a'; char2 < 'a'+l; char2++)
                        {
                            for (var num3 = Math.Max(num1, num2) + 1; num3 <=n; num3++)// Math.Max(d1, d2) + 1; d3 <= n; d3++
                            {
                                Console.Write($"{num1}{num2}{char1}{char2}{num3} ");

                            }

                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
