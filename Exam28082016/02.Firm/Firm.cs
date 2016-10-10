using System;

class Firm
{
    static void Main()
    {
        var neededHours = int.Parse(Console.ReadLine());
        var days = int.Parse(Console.ReadLine());
        var employee = int.Parse(Console.ReadLine());

        
        var timeWork = days - (days * 0.10); //time of real working
        var timeWorkHours = timeWork * 8;
        var moreHours = employee * 2 * days;

        var realWorkHours = 0.0;
        realWorkHours =  timeWorkHours + moreHours;

        if (realWorkHours > neededHours)
        {
            var result = Math.Floor(realWorkHours) - neededHours;
            Console.WriteLine("Yes!{0} hours left.", result);
        }
        else
        {
            var result2 = neededHours - Math.Floor(realWorkHours);
            Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(result2));
        }
    }
}