using System;


namespace _04.Concatenate
{
    class Concatenate
    {
        static void Main(string[] args)
        {
            var FirstName = Console.ReadLine();
            var LastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",FirstName, LastName, age, town);
        }
    }
}
