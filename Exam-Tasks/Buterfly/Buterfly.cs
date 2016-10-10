using System;

namespace Buterfly
{
    class Buterfly
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                n = 3;
            }
            else if (n > 1000)
            {
                n = 1000;
            }

            int rows = 2 * (n - 2) + 1;
            int cols = 2 * n - 1;
            int size = n - 2;

            for (int i = 1; i <= size; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}\\ /{0}",new string('*', size));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', size));
                }        
            }
            Console.WriteLine("{0} @ {0}", new string(' ', n-2));
           
            for (int i = 1; i <= size; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', size));//first row
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', size));
                }
            }
        }
    }
}