using System;
using System.Numerics;

class SimleLoopsTribonacci
{
    static void Main()
    {
        
        BigInteger t1 = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger t2 = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger t3 = new BigInteger(int.Parse(Console.ReadLine()));
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(t1);
        }
        else if (n == 2)
        {
            Console.WriteLine(t2);
        }
        else if (n == 3)
        {
            Console.WriteLine(t3);
        }
        else
        {
        BigInteger tn = 0;
            for (int i = 4; i <= n; i++)
            {
                tn = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = tn;
            }
            Console.WriteLine(tn);
        }
        
    }
}
