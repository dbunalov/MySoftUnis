using System;
class RefactorVolumeOfPyramid
{
    static void Main()
    {
        double pyramidLenght = 0.0;
        Console.Write("Length: ");
        pyramidLenght = double.Parse(Console.ReadLine());

        double pyramidWidth = 0;
        Console.Write("Width: ");
        pyramidWidth = double.Parse(Console.ReadLine());

        double pyramidHeight = 0;
        Console.Write("Height: ");
        pyramidHeight = double.Parse(Console.ReadLine());

        double pyramidVolume = (pyramidLenght * pyramidWidth * pyramidHeight) / 3;
        Console.WriteLine($"Pyramid Volume: {pyramidVolume:F2}");
    }
}