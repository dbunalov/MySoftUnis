using System;

namespace _14.NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (var rows = 0; rows < n; rows++)
            {
                for (var cols = 0; cols < n; cols++)
                {
                    var num = rows + cols + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}