using System;

class Hotel
{
    static void Main()
    {
        var month = Console.ReadLine().ToLower();
        var days = double.Parse(Console.ReadLine());
        //May, June, July, August, September или October
        var studio = 0.0;
        var apartment = 0.0;
        var studioOts = 0.0;
        var apartOts = 0.0;

        if (month == "may" || month == "october" )
        {
            studio = 50.0;
            apartment = 65.0;
            if (days > 7)
            {
                studioOts = studio * 0.05;
            }
            else if (days > 14)
            {
                studioOts = studio * 0.3;
                apartOts = apartment * 10 / 100;
            }
        }
        else if (month == "june" || month == "september")
        {
            studio = 75.20;
            apartment = 68.70;
            if (true)
            {
                studioOts = studio * 0.2;
                apartOts = apartment * 10 / 100;
            }
        }
        else if (month == "july" || month == "august")
        {
            studio = 76.0;
            apartment = 77.0;
        }
        
        

        Console.WriteLine("apart {0:0.00}", apartment);
        Console.WriteLine("studio {0:0.00}", studio);
        Console.WriteLine("ap ot {0:0.00}", apartOts);
        Console.WriteLine("st.ots {0:0.00}", studioOts);
        Console.WriteLine("---------");


        var totStudioPrice = (studio - studioOts)* days;
        var totApartPrice = (apartment - apartOts) * days;

        Console.WriteLine("Apartment: {0:0.00} lv.", totApartPrice);
        Console.WriteLine("Studio: {0:0.00} lv.",totStudioPrice);
    }
}