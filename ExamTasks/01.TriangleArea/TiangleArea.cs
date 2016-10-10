using System;

class TriangleArea
{
    static void Main()
    {
    int x1 = int.Parse(Console.ReadLine());
    int y1 = int.Parse(Console.ReadLine());

    int x2 = int.Parse(Console.ReadLine());
    int y2 = int.Parse(Console.ReadLine());

    int x3 = int.Parse(Console.ReadLine());
    int y3 = int.Parse(Console.ReadLine());

    double h = Math.Abs(y1 - y2);
    double a = Math.Abs(x2 - x3);

    double area = (a * h) / 2;
    Console.WriteLine(area);

    }
}
