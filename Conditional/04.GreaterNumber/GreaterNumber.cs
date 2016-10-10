using System;

namespace _04.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Greater number: " + a);
            }
            else
            {
                Console.WriteLine("Greater number: " + b);
            }
                
        }
    }
}
