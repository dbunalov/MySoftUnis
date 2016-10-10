using System;
class StringsAndObjects
{
    static void Main()
    {
        string greeting = "Hello";
        string toWho = "World";
        object wholeGreeting = greeting + " " + toWho;
        Console.WriteLine(wholeGreeting);
    }
}
