using System;

namespace MathPower
{
    public class MathPower
    {
        public static double RaiseToPower(double number, double power)
        {
            //double result = 0d;
            return Math.Pow(number, power);
        }
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }
    }
}
