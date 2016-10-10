using System;
class PointOnSegment
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        int segment1 = Math.Abs(first - point);
        int segment2 = Math.Abs(second - point);
        int closePoint = segment1 < segment2 ? segment1 : segment2;

        if (first > second)
        {
            int oldSecond = second;
            second = first;
            first = oldSecond;
        }
        if (point >= first && point <= second)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
        
        Console.WriteLine(closePoint);
    }
}