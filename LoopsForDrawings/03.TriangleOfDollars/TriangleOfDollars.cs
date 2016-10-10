using System;

namespace _03.TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)//increasing rows
            {              
                for (int col = 0; col < row; col++)//increasing columns
                {
                    Console.Write(col + 1 + "$ ");
                }
                Console.WriteLine();
            }
            
        }
    }
}