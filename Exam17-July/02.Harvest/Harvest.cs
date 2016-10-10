using System;

namespace _02.Harvest
{
    class Harvest
    {
        static void Main()
        {            
            var x = int.Parse(Console.ReadLine());//total sq.meters
            var y = double.Parse(Console.ReadLine());//grape for sq.meter
            var z = int.Parse(Console.ReadLine());//needed wine liters
            var empl = int.Parse(Console.ReadLine());//total employees

            double grape = x * y; //total grape from sq.meters;
            double grapeForWine = grape * 0.4; //calculate the quantity of produced grape which will be used for wine
            double wine = grapeForWine / 2.5; //calculate wine
            double wineMore = wine - z; //calculate more wine
            double wineLess = z - wine; // calculate less wine


            if (z > wine) 
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLess)} liters wine needed.");
            }
            else if (wine >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineMore)} liters left -> {Math.Ceiling(wineMore/empl)} liters per person.");
            }
        }
    }
}