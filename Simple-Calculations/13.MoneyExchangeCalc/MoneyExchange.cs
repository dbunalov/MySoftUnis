using System;

namespace _13.MoneyExchangeCalc
{
    class MoneyExchange
    {
        static void Main()
        {
            var amount = double.Parse(Console.ReadLine());//amount of money to exchange
            string currency1 = Console.ReadLine();//currency of the ammount of money
            string currency2 = Console.ReadLine();//selected currency to receive the money
            var EUR = 1.95583;
            var USD = 1.79549;
            var GBP = 2.53405;
            
            switch (currency1)
            {
                case "BGN":
                case "bgn":
                    break;
                case "EUR":
                case "eur":
                    amount = amount * EUR;
                    break;
                case "USD":
                case "usd":
                    amount = amount * USD;
                    break;
                case "GBP":
                case "gbp":
                    amount = amount * GBP;
                    break;
            }
            switch (currency2)
            {
                case "BGN":
                case "bgn":
                    break;
                case "EUR":
                case "eur":
                    amount = amount / EUR;
                    break;
                case "USD":
                case "usd":
                    amount = amount / USD;
                    break;
                case "GBP":
                case "gbp":
                    amount = amount / GBP;
                    break;
            }
            Console.WriteLine(Math.Round(amount, 2) + " " + currency2);
        }

    }
}