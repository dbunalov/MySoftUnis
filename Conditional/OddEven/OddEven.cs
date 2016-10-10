using System;

namespace OddEven
{
    class OddEven
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            //var ostatyk = num % 2;
            //var result = ostatyk == 0;

            //if (ostatyk == 0)
            if (num % 2 == 0)
            //if (result)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
