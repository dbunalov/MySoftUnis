using System;

class Hospital
{
	static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var treated = 0;
        var untreated = 0;
        var doctors = 7;

        for (int i = 0; i < n; i++)
        {
            var patients = int.Parse(Console.ReadLine());
            if (patients > 7)
            {
                untreated = patients - 7;
                treated = 7;
            }
        }

        Console.WriteLine("Treated patients: {0}.", treated);
        Console.WriteLine("Untreated patients: {0}.", untreated);
    }
}