using System;

class SumsStep3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            switch (i % 3)
            {
                case 1: sum1 += number; break;                
                case 2: sum2 += number; break;
                case 0: sum3 += number; break;
                default: break;
            }           
        }
        Console.WriteLine("sum1 = {0}",sum1);
        Console.WriteLine("sum2 = {0}",sum2);
        Console.WriteLine("sum3 = {0}",sum3);
    }
}