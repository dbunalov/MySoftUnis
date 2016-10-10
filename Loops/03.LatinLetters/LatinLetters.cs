using System;

namespace _03.LatinLetters
{
    class LatinLetters
    {
        static void Main(string[] args)
        {
            for (var letter = 97; letter <= 122; letter++)// for (int letter = 'a'; letter1 <= 'z'; letter1++)
            {
                Console.WriteLine((char)letter);  //     Console.WriteLine(letter);
            }
        }
    }
}
