using System;
class ConvertSpeedUnits
{
    static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        float totalSeconds = (hours * 3600) + (minutes * 60) + seconds ;
        float totalHours = totalSeconds / 3600;

        float metersPerSeconds = distance / totalSeconds; // calculate meters per seconds
        float kilometersPerHour = (distance / 1000) / totalHours;
        float milesPerHour = (kilometersPerHour / 1609) * 1000;

        Console.WriteLine(metersPerSeconds); // print result of m/s
        Console.WriteLine(kilometersPerHour); // print result of km/h
        Console.WriteLine(milesPerHour); // print result of mph
    }
}