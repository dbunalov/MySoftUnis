using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_To_Text
{
    class Number_To_Text
    {
        static void Main(string[] args)
        {
            string[] numbers =
            {
             "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",
            "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six","twenty seven", "twenty eight", "twenty nine", "thirty", "thirty one", "thirty two", "thirty three", "thirty four", "thirty five", "thirty six", "thirty seven", "thirty eight", "thirty nine", "forty", "fourty one", "fourty two", "fourty three", "fourty four", "fourty five", "fourty six", "fourty seven", "fourty eight", "fourty nine", "fifty", "fifty one", "fifty two", "fifty three", "fifty four", "fifty five", "fifty six", "fifty seven", "fifty eight", "fifty nine", "sixty", "sixty one", "sixty two", "sixty three", "sixty four", "sixty five", "sixty six", "sixty seven", "sixty eight", "sixty nine", "seventy", "seventy one", "seventy two", "seventy three", "seventy four", "seventy five", "seventy six", "seventy seven", "seventy eight", "seventy nine", "eighty", "eighty one", "eighty two", "eighty three", "eighty four", "eighty five", "eighty six", "eighty seven", "eighty eight", "eighty nine", "ninety", "ninety one", "ninety two", "ninety three", "ninety four", "ninety five", "ninety six", "ninety seven", "ninety eight", "ninety nine", "one hundred"
            };
            int i = int.Parse(Console.ReadLine());
            if ((i >= 0) && (i <= 100))
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == i)
                    {
                        Console.WriteLine("{0}", numbers[i]);
                    }
                }
            }
            else
                Console.WriteLine("Invalid number");
        }
    }
}