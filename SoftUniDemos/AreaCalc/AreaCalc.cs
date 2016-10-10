using System;

namespace AreaCalc
{
    class AreaCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());
            int result = a * b;
            Console.WriteLine("The area is {0}",result);
        }
    }
}
