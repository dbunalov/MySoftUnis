using System;


namespace _14.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var x1 = 0;
            var y1 = 0;//permanent
            var x2 = 0;
            var y2 = 0;//temp
            var xx1 = 0;
            var yy1 = 0;//temp
            var xx2 = 0;
            var yy2 = 0;//temp
            var h = int.Parse(Console.ReadLine());//h size of side
            var x = int.Parse(Console.ReadLine());//x point coordinates
            var y = int.Parse(Console.ReadLine());//y point coordinates

            x2 = 3 * h;
            y2 = h;

            xx1 = h;
            yy1 = h;
            xx2 = 2 * h;
            yy2 = 4 * h;

            
            if (((x == x1 || x == x2) && (y >= y1) && (y <= y2))
             || ((y == y1 || y == y2) && (x >= x1) && (x <= x2) || 
             ((x == xx1 || x == xx2) && (y >= yy1) && (y <= yy2)) 
             || ((y == yy1 || y == yy2) && (x >= xx1) && (x <= xx2))))//both
            {
                Console.WriteLine("border");
            }
            else if (x >= x1 && x <= x2 && y >= y1 && y <= y2 || 
                     x >= xx1 && x <= xx2 && y >= yy1 && y <= yy2)//both
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
