using System;
class TradeComissions
{
    static void Main(string[] args)
    {
        var town = Console.ReadLine().ToLower();
        var sell = double.Parse(Console.ReadLine());
        var commision = -1.0;

        if (0 <= sell && sell <= 500)
        {
            if (town == "sofia")
            {
                commision = 0.05;
            }
            else if (town == "varna")
            {
                commision = 0.045;
            }
            else if (town == "plovdiv")
            {
                commision = 0.055;
            }
        }
        if (500 < sell && sell <= 1000)
        {
            if (town == "sofia")
            {
                commision = 0.07;
            }
            else if (town == "varna")
            {
                commision = 0.075;
            }
            else if (town == "plovdiv")
            {
                commision = 0.08;
            }
        }
        if (1000 < sell && sell <= 10000)
        {
            if (town == "sofia")
            {
                commision = 0.08;
            }
            else if (town == "varna")
            {
                commision = 0.1;
            }
            else if (town == "plovdiv")
            {
                commision = 0.12;
            }
        }
        if (sell > 10000)
        {
            if (town == "sofia")
            {
                commision = 0.12;
            }
            else if (town == "varna")
            {
                commision = 0.13;
            }
            else if (town == "plovdiv")
            {
                commision = 0.145;
            }
        }
        if (commision == -1.0)
        {
            Console.WriteLine("error");
        }
        else
        {
            var result = sell * commision;
            Console.WriteLine($"{result:f2}");
        }
    }
        
}