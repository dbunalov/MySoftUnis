using System;

namespace EnglishNameOfLastDigit
{
    public class EnglishNameOfLastDigit
    {
        public static string GetDigitName(long number)
        {
            string nameOfLastDigit = string.Empty;
            long tempNumber = number % 10;
            
            switch (tempNumber)
            {
                case 0:
                    nameOfLastDigit = "zero";
                    break;
                case 1:
                    nameOfLastDigit = "one";
                    break;
                case 2:
                    nameOfLastDigit = "two";
                    break;
                case 3:
                    nameOfLastDigit = "three";
                    break;
                case 4:
                    nameOfLastDigit = "four";
                    break;
                case 5:
                    nameOfLastDigit = "five";
                    break;
                case 6:
                    nameOfLastDigit = "six";
                    break;
                case 7:
                    nameOfLastDigit = "seven";
                    break;
                case 8:
                    nameOfLastDigit = "eight";
                    break;
                case 9:
                    nameOfLastDigit = "nine";
                    break;

                default:
                    break;
            }
            return nameOfLastDigit;
        }
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string result = GetDigitName(Math.Abs(number));
            Console.WriteLine(result);
        }
    }
}
