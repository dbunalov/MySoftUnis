using System;

namespace _04.EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i+=2)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
