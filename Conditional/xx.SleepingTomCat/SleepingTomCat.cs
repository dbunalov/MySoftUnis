using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xx.SleepingTomCat
{
    class SleepingTomCat
    {
        static void Main(string[] args)
        {
//Пример: 20 почивни дни -> работните дни са 345 (365 – 20 = 245). 
//Реалното време за игра е 24 275 минути (345 * 63 + 20 *127).  
//Разликата от нормата е 5 725 минути (30 000 – 24 275 = 5 725) или 95 часа и 25 минути.

//Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
//Когато почива, стопанинът му си играе с него по 127 минути на ден.

           
            var DaysOff = int.Parse(Console.ReadLine());//input days off for an year
            var WorkDays = 365 - DaysOff; //working days for an year
            var PlayTimeNorm = 30000;//Play time norm for an year
            var PlayTimeWD = WorkDays * 63;//total play time per year working days
            var PlayTimeDO = DaysOff * 127;//total play time per year day off
            var TotalPlayTime = PlayTimeWD + PlayTimeDO;
            var playTime = 0.0;
            //var PlayTimeWDDayly = WorkDays * 63;
            //var PlayTimeDODayly = DaysOff * 127;
            Console.WriteLine("working days              {0}", WorkDays);
            Console.WriteLine("Total play time           {0}", TotalPlayTime);
            Console.WriteLine("Play time when at work    {0}", PlayTimeWD);
            Console.WriteLine("Play time when at day off {0}", PlayTimeDO);
            //playTime = TotalPlayTime - PlayTimeNorm;
            //Console.WriteLine("play time more/less       {0}", playTime);

            if (TotalPlayTime > PlayTimeNorm)
            {
                playTime = TotalPlayTime - PlayTimeNorm;
                Console.WriteLine("Tom will run away");
                playTime = playTime / 60;
                Console.WriteLine(playTime);
                var hhh = Math.Truncate(playTime);
                var mmm = playTime - Math.Truncate(playTime);
                Console.WriteLine("{0} hours and {1} minutes more for play", hhh, mmm) ;
            }
            else
            {
                playTime = PlayTimeNorm - TotalPlayTime;
                Console.WriteLine("Tom sleeps well");
                playTime = playTime / 60;
                Console.WriteLine(playTime);
                var hhh = Math.Truncate(playTime);
                var mmm = playTime - Math.Truncate(playTime);
                Console.WriteLine("{0} hours and {1} minutes less for play", hhh, mmm);
            }
        }
    }
}
