using System;

namespace _19.YardAndTiles
{
    class YardAndTiles
    {
        static void Main()
        {
            var yardBase = int.Parse(Console.ReadLine()); //N
            var tileWidth = double.Parse(Console.ReadLine());//W
            var tileLenght = double.Parse(Console.ReadLine());//L
            var benchWidht = int.Parse(Console.ReadLine());//M
            var benchLenght = int.Parse(Console.ReadLine());//O
            //Calculations
            var yardArea = Math.Pow(yardBase, 2); //The area of the yard
            var benchArea = benchLenght * benchWidht;//The area of the bench
            var yardFree = yardArea - benchArea;//The area of the yard w/o the bench
            var tile = tileLenght * tileWidth;//The area of 1 tile
            var tileNumbers = yardFree / tile;//Calculating tile numbers
            Console.WriteLine(tileNumbers);//Print tile numbers
            var time = tileNumbers * 0.2;//Calculating time to put tiles
            Console.WriteLine(time);//Print time
        }
    }
}