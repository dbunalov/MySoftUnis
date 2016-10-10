using System;
class CircleArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double result = 0.0;
        result = Math.PI * Math.Pow(r,2);
        Console.WriteLine($"{result:f12}");
    }
}