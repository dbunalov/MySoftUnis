using System;
using System.Collections.Generic;
using System.Linq;


namespace ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main()
        {
            Point[] points = Readpoints();
            Point[] closestPoints = FindClosestTwoPoints(points);
            PrintDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
            //double distance = CalcDistance(closestPoints[0], closestPoints[1]);

            //foreach (Point point in points)
            //{
            //    PrintPoint(point);
            //}

        }
        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = new Point[2];
            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints[0] = points[p1];
                        closestTwoPoints[1] = points[p2];
                    }
                }
            }
            return closestTwoPoints;
        }
        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine($"{distance:f3}");
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
        
            static Point Readpoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }
        static Point[] Readpoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = Readpoint();
            }
            return points;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
