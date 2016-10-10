using System;

namespace SmartLili
{
    class SmartLili
    {
        static void Main()
        {
            double moneyCollect = 0.0;
            double totalMoney = 0.0;
            double toys = 0.0;
            double moneyPlus = 0.0;

            string evenOrOdd = "";

            int age = int.Parse(Console.ReadLine());// Lilis age
            double x = double.Parse(Console.ReadLine());//washing machine price
            int p = int.Parse(Console.ReadLine());//price per toy

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyCollect = moneyCollect + 10.0 + moneyPlus;//collecting money if age is even
                    moneyCollect -= 1.0;//her bro took 1.00 from her money
                    moneyPlus += 10.0;
                }
                else if (i % 2 != 0)
                {
                    toys += 1.0;//collecting new toy if age is odd
                }
            }

            
            double moneyFromToys = toys * p;
            totalMoney = moneyCollect + moneyFromToys;

            if (totalMoney >= x)
            {
                Console.WriteLine($"Yes! {(totalMoney - x):f2}");
            }

            else
            {
                Console.WriteLine($"No! {(x - totalMoney):f2}");
            }
        }
    }
}