using System;
using System.Linq;

namespace NumbersInReversedOrder
{
    public class NumbersInReversedOrder
    {
        public static double ReverseDouble(double num)
        {
            string reversedStr = new string(num.ToString().Reverse().ToArray());
            double reversedDouble;
            if (double.TryParse(reversedStr, out reversedDouble))
            {
            }
            else
            {
            }
            return reversedDouble;
        }
       
    
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double reversedNumber = ReverseDouble(num);
            Console.WriteLine(reversedNumber);
        }
    }
}
