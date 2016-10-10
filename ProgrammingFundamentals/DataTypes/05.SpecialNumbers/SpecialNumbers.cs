using System;
class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            bool result = false;
            int sum = 0;
            sum = (i / 10) + (i % 10);
            if (sum == 5 || sum == 7 || sum == 11)
            {
                result = true;
            }
            Console.WriteLine($"{i} -> {result}");
        }
    }
}