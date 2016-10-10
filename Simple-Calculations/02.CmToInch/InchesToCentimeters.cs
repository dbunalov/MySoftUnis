using System;

namespace _02.InchtoCm
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inch = double.Parse(Console.ReadLine());
            var centimeters = inch * 2.54;
            Console.WriteLine("centimeters = {0}",centimeters);
        }
    }
}
