using System;

namespace StopSign
{
    class StopSign
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

            //first line
            int dots = n + 1;
            int dash = 2 * n + 1;

            Console.WriteLine("{0}{1}{0}", new string('.', n+1), new string('_',dash));
            dash -= 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', --dots), new string('_', dash));
                dash += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (dash-5)/2));
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', dash));
                dash -= 2;
            }
        }
    }
}