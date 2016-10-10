using System;

namespace _18.Borsa
{
    class Borsa
    {
        static void Main()
        {
            var priceKiloVeg = double.Parse(Console.ReadLine());
            var priceKiloFru = double.Parse(Console.ReadLine());
            var kilosVeg = int.Parse(Console.ReadLine());
            var kilosFru = int.Parse(Console.ReadLine());
            var EUR = 1.94;
            var vegTot = priceKiloVeg * kilosVeg / EUR;
            var fruTot = priceKiloFru * kilosFru / EUR;
            var totAmount = vegTot + fruTot;
            Console.WriteLine(totAmount);
            //var profit = (priceKiloVeg * kilosVeg + priceKiloFru * kilosFru) / 1.94;
            //Console.WriteLine(profit); 

        }
    }
}
