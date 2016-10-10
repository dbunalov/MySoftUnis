using System;
class HelloNamee
{
    private static void HelloName()
    {
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
    static void Main()
    {
        HelloName();
    }
}