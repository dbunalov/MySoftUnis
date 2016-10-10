using System;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] bases = { 16, 2 };
        int[] numbers = { num };

        foreach (int baseValue in bases)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine("{1}",
                                  number, Convert.ToString(number, baseValue).ToUpper());
            }
        }
    }
}