using System;

namespace _01.CheckGrade
{
    class CheckGrade
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >=5.50)
            {
                Console.WriteLine("Excellent!");

            }
        }
    }
}
