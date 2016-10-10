using System;
class RefactorSpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        
        for (int counter = 1; counter <= n; counter++)
        {
            int number = 0;
            int sum = 0;

            number = counter;
            while (counter > 0)
            {
                sum += counter % 10;
                counter = counter / 10;
            }
            bool isNeeded = false;
            isNeeded = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{number} -> {isNeeded}");
            sum = 0;
            counter = number;
        }
    }
}