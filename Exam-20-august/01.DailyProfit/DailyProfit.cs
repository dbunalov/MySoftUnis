using System;

class DailyProfit
{
	static void Main()
    {
        var workingDays = int.Parse(Console.ReadLine());
        var dailyMoney = double.Parse(Console.ReadLine());
        var exchange = double.Parse(Console.ReadLine());

        var monthlyProfit = 0.0;
        var yearlyProfit = 0.0;
        var clearProfit = 0.0;
        var dailyProfit = 0.0;
       
        monthlyProfit = workingDays * dailyMoney;
        yearlyProfit = (12 * monthlyProfit) + (2.5 * monthlyProfit);
        clearProfit = yearlyProfit - (yearlyProfit * 0.25);

        dailyProfit = clearProfit * exchange / 365;
        
        Console.WriteLine("{0:f2}",dailyProfit);
    }
}