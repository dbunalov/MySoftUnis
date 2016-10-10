using System;

class Firm
{
	static void Main()
    {
        var hoursNeeded = int.Parse(Console.ReadLine());
        var daysPerProj = int.Parse(Console.ReadLine());
        var employees = int.Parse(Console.ReadLine());

        var workingHours = (daysPerProj * 8) - (daysPerProj * 8 * 0.1);
        var moreHours = employees * 2 * daysPerProj;
        var totalHours = Math.Floor(workingHours) + moreHours;
        var result = Math.Abs(totalHours - hoursNeeded);

        if (hoursNeeded > totalHours)
        {
            Console.WriteLine("Not enough time!{0} hours needed.", result);
        }
        else
        {
            Console.WriteLine("Yes!{0} hours left.", result);
        }
    }
}
