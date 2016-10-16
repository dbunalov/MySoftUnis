using System;
using System.Collections.Generic;
using System.Linq;


namespace DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
    
        static void Main()
        {
            Point p1 = Readpoint();
            Point p2 = Readpoint();
            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"{distance:f3}");
        }
        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2));
        }
        static Point Readpoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
