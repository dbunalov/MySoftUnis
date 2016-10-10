using System;


namespace CelsiusToFahrenheit
{
    class CelToFah
    {
        static void Main(string[] args)
        {
            var cel = double.Parse(Console.ReadLine());
            var fah = (cel * 1.8) + 32;
            Console.WriteLine(fah);
        }
    }
}
