using System;
class VariableInHexFormat
{
    static void Main()
    {
        string valueInHex = Console.ReadLine();

        Console.WriteLine(Convert.ToInt32(valueInHex, 16));
    }
}
