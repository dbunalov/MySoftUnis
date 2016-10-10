using System;

namespace DrawFilledSquare
{
    public class DrawFilledSquare
    {
        public static void PrintHeadFoot(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        public static void PrintMiddleLines(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeadFoot(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddleLines(n);
            }
            PrintHeadFoot(n);
        }
    }
}
