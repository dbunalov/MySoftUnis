using System;

class DateAfter5Days
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        string stringMonth = Console.ReadLine();
        int month;
        if (stringMonth[0] == '0')
        {
            month = int.Parse(stringMonth[1].ToString());
        }
        else
        {
            month = int.Parse(stringMonth);
        }
        DateTime date = new DateTime(2015, month, days);// need non-leap year !!!

        date = date.AddDays(5);

        if (date.Month > 9)
        {
            Console.WriteLine("{0}.{1}",date.Day, date.Month);
        }
        else
        {
            Console.WriteLine("{0}.0{1}",date.Day, date.Month);

        }

    }
}