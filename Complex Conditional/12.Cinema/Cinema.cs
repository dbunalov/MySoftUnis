using System;

namespace _12.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var ticketType = Console.ReadLine().ToLower();
            var isles = int.Parse(Console.ReadLine());
            var sitPlaces = int.Parse(Console.ReadLine());
            var amount = isles * sitPlaces;
            switch (ticketType)
            {
                case "premiere":
                    Console.WriteLine("{0:f2} leva",12 * amount);
                    break;
                case "normal":
                    Console.WriteLine("{0:f2} leva", 7.50 * amount);
                    break;
                case "discount":
                    Console.WriteLine("{0:f2} leva", 5 * amount);
                    break;
                default:
                    break;
            }
        }
    }
}
