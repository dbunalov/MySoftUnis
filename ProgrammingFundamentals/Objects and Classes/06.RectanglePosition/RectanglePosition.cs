using System;
using System.Collections.Generic;
using System.Linq;


namespace RectanglePosition
{
    class RectanglePosition
    {
        static void Main()
        {
            Rectangle rect1 = ReadRectangle();
            Rectangle rect2 = ReadRectangle();
            Console.WriteLine(rect1.isInside(rect2) ? "Inside" : "Not inside");
        }
        static Rectangle ReadRectangle()
        {
            int[] rectInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rect = new Rectangle();
            rect.Top = rectInfo[0];
            rect.Left = rectInfo[1];
            rect.Width = rectInfo[2];
            rect.Height = rectInfo[3];
            return rect;
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int CalcArea()
        {
            return Width * Height;
        }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool isInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}