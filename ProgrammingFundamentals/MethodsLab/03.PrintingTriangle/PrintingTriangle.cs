using System;

namespace PrintingTriangles
{
    public class PrintingTriangles
    {
        static void PrintLine(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

        }
    }
}