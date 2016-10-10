using System;


namespace _01.Print10Stars
{
    class Print10Stars
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}
