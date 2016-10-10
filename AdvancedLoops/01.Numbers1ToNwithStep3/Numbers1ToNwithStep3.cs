using System;

namespace _01.Numbers1ToNwithStep3
{
    class Numbers1ToNwithStep3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
