using System;

namespace _14.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main()
        {
            //square, rectangle, circle или triangle

            var figure = Console.ReadLine().ToLower();
            if (figure == "square")
            {
                var num = double.Parse(Console.ReadLine());
                var area = Math.Pow(num, 2);
                Console.WriteLine("{0:0.000}", area);
            }
            else if (figure == "rectangle")
            {
                var num1 = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                var area = num1 * num2;
                Console.WriteLine("{0:0.000}", area);
            }
            else if (figure == "circle")
            {
                var num = double.Parse(Console.ReadLine());
                var area = Math.PI * Math.Pow(num, 2);
                Console.WriteLine("{0:0.000}", area);
            }
            else if (figure == "triangle")
            {
                var num1 = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                var area = num1 * num2 / 2.0;
                Console.WriteLine("{0:0.000}", area);
            }
        }
    }
}