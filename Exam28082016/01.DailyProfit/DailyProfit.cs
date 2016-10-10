using System;

class DailyProfit
{
    static void Main()
    {
        var monthlyWD = int.Parse(Console.ReadLine());
        var moneyPerDay = double.Parse(Console.ReadLine());
        var exchangeCourse = double.Parse(Console.ReadLine());

        var zaplata = monthlyWD * moneyPerDay;
        var zaplataGodina = zaplata * 12 + zaplata * 2.5;
        var danak = zaplataGodina * 0.25;
        var totalD = zaplataGodina - danak;
        var tovalL = totalD * exchangeCourse;

        Console.WriteLine("{0:0.00}", tovalL/365);
    }
}