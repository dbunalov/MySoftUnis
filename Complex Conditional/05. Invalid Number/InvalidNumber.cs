using System;

namespace _05.Invalid_Number
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            //Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която въвежда цяло число и печата “invalid” ако въведеното число не е валидно. Примери:
            var num = int.Parse(Console.ReadLine());
            var range = (num >= 100 && num <= 200) || num == 0 ;
     
            if (!range)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
