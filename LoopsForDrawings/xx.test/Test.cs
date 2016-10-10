using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2) n = 2;
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
            int a = 0;
            int b = n - 4;
            for (int i = 1; i < n; i++)//
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', 3 * n + a));
                a += 2;
            }
            Console.WriteLine(new string('*', 5 * n));
            for (int i = 2 * n; i >= 1; i--)
            {
                b--;
                Console.WriteLine("{0}*{1}*{0}", new string('.', 2 * n - i + 1), new string('.', 2 * i + b + 1));
                b++;
            }
            if (n >= 3)
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
        }
    }
}