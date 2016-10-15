using System;
using System.Globalization;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string dateText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
