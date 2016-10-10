using System;
class Bricks
{
    static void Main()
    {
        int bricks = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int bricksPerCourse = int.Parse(Console.ReadLine());

        double course = workers * bricksPerCourse;
        double totalCourses = bricks / course;

        Console.WriteLine(Math.Ceiling(totalCourses));
    }
}