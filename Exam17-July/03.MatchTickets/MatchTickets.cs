using System;

namespace _03.MatchTickets
{
    class MatchTickets
    {
        static void Main()
        {
            var vip = 499.99;
            var normal = 249.99;

            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var groupNumber = double.Parse(Console.ReadLine());
            var moneyLeft = 0.0;
            var transport = 0.0;
            var tickets = 0.0;
            var money = 0.0;

            if (groupNumber >=1 && groupNumber <= 4)
            {
                transport = budget * 0.75;
            }

            else if (groupNumber >= 5 && groupNumber <= 9)
            {
                transport = budget * 0.60;
            }
            else if (groupNumber >= 10 && groupNumber <= 24)
            {
                transport = budget * 0.50;
            }
            else if (groupNumber >= 25 && groupNumber <= 49)
            {
                transport = budget * 0.40;
            }
            else if (groupNumber >= 50)
            {
                transport = budget * 0.25;
            }
            
            switch (category) //calc total amount of tickets
            {
                case "vip":
                    tickets = groupNumber * vip;// numb of people * price of vip ticket
                    break;
                case "normal":
                    tickets = groupNumber * normal;// numb of people * price of normal ticket
                    break;
                default:
                    break;
            }

            moneyLeft = budget - transport;//money left after calc transportation fees

            money = tickets - moneyLeft;//money left after transportation and tickets fees
            var moneyPlusTickets = money + tickets;

            //printing result
            if (tickets > moneyLeft)
            {
                Console.WriteLine("Not enough money! You need {0:0.00} leva.", tickets - moneyLeft);
            }
            else if (moneyLeft > tickets)
            {
                Console.WriteLine("Yes! You have {0:0.00} leva left.", moneyLeft - tickets);
            }
        }
    }
}