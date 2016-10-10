using System;

class BackInPast
{
    static void Main()
    {
        var money = double.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());

        //starting year = 1800
        //starting age  = 18
        //even year = 12000
        //odd year = 12000 + 50 * age


        var age = 0;
        var newYear = 1800;
        var sumSpent = 0.0;
        var sumLeft = 0.0;
        for (int i = 1800; i <= year; i++)
        {
            age = (18 + i) - 1800;
            newYear = i;

            if (newYear % 2 == 0)
            {
                sumSpent += 12000.0;
                sumLeft = money - sumSpent;
            }
            else if (newYear % 2 != 0)
            {
                sumSpent += 12000.0 + 50 * age;
                sumLeft = money - sumSpent;
            }
        }
        if (sumLeft >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {sumLeft:F2} dollars left.");
        }
        else
        {
            var moneyNeed = sumLeft - money;
            Console.WriteLine($"He will need {Math.Abs(sumLeft):f2} dollars to survive.");
        }
    }
}