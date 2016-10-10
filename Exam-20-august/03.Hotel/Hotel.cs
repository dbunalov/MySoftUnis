using System;

class Hotel
{
	static void Main()
    {
        var month = Console.ReadLine().ToLower();//May, June, July, August, September,  October
        var days = int.Parse(Console.ReadLine());

        var studio = 0.0;
        var apartment = 0.0;

        if (month == "may" || month == "october")
        {
            studio = 50.0;
            apartment = 65.0;

            if (days > 14)
            {
                studio = studio - (studio * 0.3);
                apartment = apartment - (apartment * 0.1);
            }
            else if (days > 7)
            {
                studio = studio - (studio * 0.05);
            }
        }
        else if (month == "june" || month == "september")
        {
            studio = 75.20;
            apartment = 68.70;
            if (days > 14)
            {
                studio = studio - (studio * 0.2);
                apartment = apartment - (apartment * 0.1);
            }
        }
        else if (month == "july" || month == "august")
        {
            studio = 76.0;
            apartment = 77.0;

            if (days > 14)
            {
                apartment = apartment - (apartment * 0.1);
            }
        }

            var priceStudio = days * studio;
            var priceApart = days * apartment;

            Console.WriteLine("Apartment: {0:f2} lv.", priceApart);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }
}
