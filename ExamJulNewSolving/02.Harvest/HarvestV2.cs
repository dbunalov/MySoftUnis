using System;

class HarvestV2
{
    static void Main()
    {
        var fieldSqMTotal = int.Parse(Console.ReadLine()); ;//x int 10...5000
        var grapeOnSqM = double.Parse(Console.ReadLine()); ;//y double 0.0 ... 10.00
        var neededLitersOfWine = double.Parse(Console.ReadLine()); ;//int 10...600
        var employees = int.Parse(Console.ReadLine()); ;//int 1...20

        var fieldForWine = fieldSqMTotal * 40 / 100;
        var grapeTotal = fieldForWine * grapeOnSqM;
        var wineProduced = grapeTotal / 2.5;

        if (wineProduced >= neededLitersOfWine)
        {
            var moreWine = wineProduced - neededLitersOfWine;
            var winePerEmployee = moreWine / employees; 
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
            Console.WriteLine($"{Math.Ceiling(moreWine)} liters left -> {Math.Ceiling(winePerEmployee)} liters per person.");
        }
        else
        {
            var wineLess = neededLitersOfWine - wineProduced;
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLess)} liters wine needed.");
            
        }
    }
}