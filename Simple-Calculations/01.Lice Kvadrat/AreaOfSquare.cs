using System;

namespace _01.Lice_Kvadrat
{
    class AreaOfSquare
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("Square = {0}",area);
        }
    }
}
