using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine($"Before:\na = {a}\nb = {b}");
        int oldB = a;
        a = b;
        b = oldB;
        Console.WriteLine($"After:\na = {a}\nb = {b}");
    }
}