using System;
using System.Linq;

class ReversedChars
{
    static void Main(string[] args)
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char thirdLetter = char.Parse(Console.ReadLine());
        string allLetters = Convert.ToString(firstLetter) + Convert.ToString(secondLetter) + Convert.ToString(thirdLetter);
        string result = new string(allLetters.ToCharArray().Reverse().ToArray());
        Console.WriteLine(result);
    }
}