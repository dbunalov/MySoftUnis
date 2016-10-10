using System;

namespace _15.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            var h1 = int.Parse(Console.ReadLine()); // exam hour
            var m1 = int.Parse(Console.ReadLine()); // exam mins
            var h2 = int.Parse(Console.ReadLine()); // arrive hour
            var m2 = int.Parse(Console.ReadLine()); // arrive mins

            var time1 = h1 * 60 + m1;//convert hours to minutes + minutes = begin hour
            var time2 = h2 * 60 + m2;//convert hours to minutes + minutes = student appearing
            var difference = time2 - time1;
            string condition = "";

            if (difference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (difference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }


            if (difference != 0)
            {
                var hh = Math.Abs(difference / 60);
                var mm = Math.Abs(difference % 60);

                if (difference < 0)
                {
                    condition = "before";
                }
                else
                {
                    condition = "after";
                }

                if (hh > 0)
                {
                    if (mm < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours " + condition + " the start", hh, mm);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours " + condition + " the start", hh, mm);
                    }
                }
                else
                {
                    Console.WriteLine("{0} minutes " + condition + " the start", mm);
                }
            }

        }
    }
}