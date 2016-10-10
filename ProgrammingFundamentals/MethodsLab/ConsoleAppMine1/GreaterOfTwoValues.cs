using System;

namespace GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {

        public static int GetMax(int first, int second)
        {
            int biggerValue = 0;
            if (first > second)
            {
                return biggerValue = first;
            }
            else
            {
                return biggerValue = second;
            }
        }
        public static char GetMax(char first, char second)
        {
            char biggerValue = 'a';
            if (first > second)
            {
                return biggerValue = first;
            }
            else
            {
                return biggerValue = second;
            }
        }
        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else 
            {
                return second;
            }
        }
        public static void Main()
        {
            string valueInput = Console.ReadLine().ToLower();


            switch (valueInput)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int max = GetMax(first, second);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string maxString = GetMax(firstString, secondString);
                    Console.WriteLine(maxString);
                    break;
                default:
                    break;
            }
        }
    }
}