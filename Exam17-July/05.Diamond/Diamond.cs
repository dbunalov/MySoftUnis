using System;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            if (n < 4) n = 4;

            string firstLine = String.Format("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
            Console.WriteLine(firstLine);

            int rows = n;
            int addA = 0;
            int addB = n-4;
            for (int i = 1; i < n; i++)
            {
                string nextLine = String.Format("{0}*{1}*{0}", new string('.', n - i), new string('.', 3 * n + addA));
                Console.WriteLine(nextLine);
                addA += 2;
            }
            string starsLine = String.Format(new string('*', 5 * n));
            Console.WriteLine(starsLine);

            for (int j = 2 * n; j >= 1; j--)
            {
                addB--;
                string nextLines = String.Format("{0}*{1}*{0}", new string('.', 2 * n - j+1), new string('.', 2 * j + addB + 1));
                Console.WriteLine(nextLines);
                addB++;
            }

            if (n >= 3)
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
        }
    }
}