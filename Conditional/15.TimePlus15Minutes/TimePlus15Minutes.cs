using System;

namespace _15.TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            var hrs = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            min = min + 15;

            if (min > 59)
            {
                hrs = hrs + 1;
                min = min - 60;
            }
            if (hrs > 23)
            {
                hrs = hrs - 24;
            }
            if (min < 10)
            {
                Console.WriteLine(hrs + ":0" + min);
            }
            else
            {
                Console.WriteLine(hrs + ":" + min);
            }
        }
    }
}