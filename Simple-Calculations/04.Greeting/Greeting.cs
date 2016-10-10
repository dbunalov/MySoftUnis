using System;

namespace _03.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}