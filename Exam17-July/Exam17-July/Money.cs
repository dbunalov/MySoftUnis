using System;

namespace _01.Money
{
    class Money
    {
        static void Main()
        {
            int bitCoin = 1168;
            double dollar = 1.76;
            double euro = 1.95;
            double chYuan = 0.15; //of 1 dollar
            double result = 0.0;


            int numbBitCoins = int.Parse(Console.ReadLine());
            double numbChYuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            int totBitCoins = numbBitCoins * bitCoin;//bitcoins in leva
            double totChToDollar = numbChYuan * chYuan * dollar;//yuans to leva
            double sumToEuro = (totBitCoins + totChToDollar) / euro;
            double comm = sumToEuro * commission / 100;
            result = sumToEuro - comm;

            Console.WriteLine(result);
        }
    }
}
