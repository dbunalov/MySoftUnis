using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var destination = ""; //Bulgaria, Balkans, Europe
            var typeOfTrip = "";  //Camp, Hotel
            var price = 0.00;

            if (budget <= 100 && season == "summer") //if budget less than 100
            {
                destination = "Bulgaria";
                typeOfTrip = "Camp";
                price = budget * 0.30;
            }
            else if (budget <= 100 && season == "winter")
            {
                destination = "Bulgaria";
                typeOfTrip = "Hotel";
                price = budget * 0.70;
            }
            else if ((budget <= 1000 && budget > 100) && season == "summer")
            {
                destination = "Balkans";
                typeOfTrip = "Camp";
                price = budget * 0.40;
            }
            else if ((budget <= 1000 && budget > 100) && season == "winter")
            {
                destination = "Balkans";
                typeOfTrip = "Hotel";
                price = budget * 0.80;
            }
            else
            {
                destination = "Europe";
                typeOfTrip = "Hotel";
                price = budget * 0.90;
            }


            Console.WriteLine("Somewhere in "+destination); 
            Console.WriteLine(typeOfTrip+" - {0:0.00}",price);
        }
    }
}