using System;

namespace _13.Voleyball
{
    class Voleyball
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine().ToLower();      //leap or normal
            var p = double.Parse(Console.ReadLine());  //numbers of holidays
            var h = double.Parse(Console.ReadLine());  //numbers of weekends in hometown
            var totalWeekends = 48;                 //total weekedns per year
            var playTimeSf = 0.0;                     //when he plays
            var playTimeHT = 0.0;
            var SfWeekends = 0.0;
            var playOnHolidays = 0.0;
            var totalPlay = 0.0;

            SfWeekends = totalWeekends - h;
            playTimeSf = SfWeekends * 3 / 4;
            playTimeHT = h * 1;
            playOnHolidays = p * 2 / 3;
            totalPlay = playTimeSf + playTimeHT + playOnHolidays;

            if (yearType == "normal")
            {
                Console.WriteLine(Math.Floor(totalPlay));
            }
            else if (yearType == "leap")
            {                
                totalPlay = totalPlay + (totalPlay * 0.15);
                Console.WriteLine(Math.Floor(totalPlay));
            }
        }
    }
}
