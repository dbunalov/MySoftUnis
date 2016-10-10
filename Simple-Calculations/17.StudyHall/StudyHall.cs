using System;


namespace _17.StudyHall
{
    class StudyHall
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());//lenght
            var width = double.Parse(Console.ReadLine());//width
            double realHeight = height * 100;
            double realWidth = (width * 100) - 100;
            double rows1 = realHeight / 120;
            double rows = Math.Floor(rows1);
            var buros1 = realWidth / 70;
            var buros = Math.Floor(buros1);
            var hallFreeArea = rows * buros - 3;
            Console.WriteLine(hallFreeArea);
        }
    }
}
