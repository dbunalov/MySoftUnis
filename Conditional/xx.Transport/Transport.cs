using System;

namespace xx.Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            var kilometers = int.Parse(Console.ReadLine());//day night
            var tariff = Console.ReadLine();
    
            var rate = 0.9;
            if (tariff == "day")
                rate = 0.79;
            if (kilometers < 20)
                Console.WriteLine(kilometers * rate + 0.7);
            else if (kilometers < 100)
                Console.WriteLine(kilometers * 0.09);
            else
                Console.WriteLine(kilometers * 0.06);             
        }
    }
}