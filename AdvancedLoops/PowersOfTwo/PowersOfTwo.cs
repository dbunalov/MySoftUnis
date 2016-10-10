using System;

namespace PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(2,i));
            }

        }
    }
}
