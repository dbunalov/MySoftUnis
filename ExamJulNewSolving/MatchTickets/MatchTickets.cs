using System;

class MatchTickets
{
    static void Main()
    {
        var budget = double.Parse(Console.ReadLine());
        var ticketType = Console.ReadLine().ToLower();
        var group = int.Parse(Console.ReadLine());

        var transport = 0.0;
        if (group >= 1 && group <= 4)//budget calc
        {
            transport = budget * 75 / 100;
        }
        else if (group >= 5 && group <= 9)
        {
            transport = budget * 60 / 100;
        }
        else if (group >= 10 && group <=24)
        {
            transport = budget * 50 / 100;
        }
        else if (group >= 25 && group <=49)
        {
            transport = budget * 40 / 100;
        }
        else if (group >= 50)
        {
            transport = budget * 25 / 100;
        }

        var tickets = 0.0;
        
        if (ticketType == "normal")
        {
            tickets = group * 249.99;
        }
        else if (ticketType == "vip")
        {
            tickets = group * 499.99;
        }

        var totalPrice = transport + tickets;
        var sumLeft = budget - totalPrice;

        if (sumLeft > 0)
        {
            Console.WriteLine($"Yes! You have {sumLeft:f2} leva left.");
        }
        else if (sumLeft < 0)
        {
            var sumNeeded = totalPrice - budget;
            Console.WriteLine($"Not enough money! You need {sumNeeded:f2} leva.");
        }
    }
}