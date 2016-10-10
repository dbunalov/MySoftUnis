using System;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var result = 0.0;

            if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    result = 2.7 * quantity;
                }
                else if (fruit == "apple")
                {
                    result = 1.25 * quantity;
                }
                else if (fruit == "orange")
                {
                    result = 0.9 * quantity;
                }
            }
            else
            {
                if (fruit == "banana")
                {
                    result = 2.7 * quantity;
                }
                else if (fruit == "apple")
                {
                    result = 1.25 * quantity;
                }
                else if (fruit == "orange")
                {
                    result = 0.9 * quantity;
                }
            }
        }
    }
}