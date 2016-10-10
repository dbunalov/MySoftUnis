using System;

namespace SleepyTom
{
    class SleepyTom
    {
        static void Main()
        {
            int leaveDays = int.Parse(Console.ReadLine());

            int workingDays = 365 - leaveDays;

            int playWd = workingDays * 63;//calc play time during working days
            int playLd = leaveDays * 127;//calc play time during leave days
            int totalPlayTime = playWd + playLd;
            double playTimeDiff = Math.Abs(30000 - totalPlayTime);

            double hours = Math.Abs(playTimeDiff / 60);
            double minutes = Math.Abs(playTimeDiff % 60);

            if (totalPlayTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes less for play");
            }
        }
    }
}
