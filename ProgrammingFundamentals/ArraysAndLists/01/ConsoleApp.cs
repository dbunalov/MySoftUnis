using System;

namespace HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday","Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day >=1 && day <=7)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
            {
                //Console.WriteLine("Invalid day!");
                for (int index = 0; index < days.Length; index++)
                {
                    Console.WriteLine($"arr[{index}] = {days[index]}");
                }
            }
        }
    }
}