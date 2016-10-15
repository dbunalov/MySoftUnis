using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace BigFactirial
{
    class BigFactirial
    {
        static void Main()
        {            
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }

       
    }
}
