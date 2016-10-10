using System;

namespace _06.CircleSP
{
    class TriangleSP
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var S = Math.PI * radius * radius;
            var P = 2 * Math.PI * radius;
            Console.WriteLine("Area = {0}", S);
            Console.WriteLine("Perimeter = {0}",P ); 
        }
    }
}
