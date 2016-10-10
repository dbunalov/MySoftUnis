using System;

class MoneyV2
{
    static void Main()
    {
        var bitCoins = int.Parse(Console.ReadLine());//[0…20]
        var yuans = double.Parse(Console.ReadLine());//[0.00… 50 000.00]
        var comm = double.Parse(Console.ReadLine());//[0.00... 5.00]

        var bitCoinsInLeva = bitCoins * 1168;
        var yuansInDollars = yuans * 0.15;
        var yuansInLeva = yuansInDollars * 1.76;
        var sumInLeva = bitCoinsInLeva + yuansInLeva;
        var sumInEuro = sumInLeva / 1.95;
        var commision = sumInEuro * comm / 100;
        var resultInEuro = sumInEuro - commision;
        
        Console.WriteLine(resultInEuro);
    }
}