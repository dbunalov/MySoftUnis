using System;

namespace _02._10.AreaOfTriangle
{
    class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (a * h) / 2.0;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
