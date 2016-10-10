using System;


namespace USD_to_BGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            var USD = 1.79549;
            var BGN = Double.Parse(Console.ReadLine());
            var exch = USD * BGN;
            Console.WriteLine(Math.Round(exch, 2)+ " BGN");
        }
    }
}
