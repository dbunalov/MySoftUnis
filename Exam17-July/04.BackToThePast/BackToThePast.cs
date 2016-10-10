using System;

namespace _04.BackToThePast
{
    class BackToThePast
    {
        static void Main()
        {
            var startAge = 0;
            var heritage = double.Parse(Console.ReadLine());
            var finalYear = int.Parse(Console.ReadLine());
            var moneyLeft = 0.0;
            var spentMoney = 0.00;//money spended per year

            for (int i = 1800; i <= finalYear; i++)//calc money and Ivanchos age
            {
                startAge = (i + 18) - 1800;// counting Ivanchos age
                if (i % 2 == 0)//calc money
                {
                    spentMoney += 12000.0;
                    moneyLeft = heritage - spentMoney;
                }
                else if (i % 2 != 0)
                {
                    spentMoney += 12000.0 + (50 * startAge);
                    moneyLeft = heritage - spentMoney;
                }
            }
            if (moneyLeft >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", moneyLeft);
            }
            else
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.", Math.Abs(moneyLeft));
            }
        }
    }
}
