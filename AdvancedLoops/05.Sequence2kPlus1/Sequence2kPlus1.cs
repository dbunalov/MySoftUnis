using System;

namespace _05.Sequence2kPlus1
{
    class Sequence2kPlus1
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            //int myNumber = 1;

            for (int i = 1; i <= counter; i = 2 * i + 1)

            {
                Console.WriteLine(i);
            }
           
            //while (myNumber <= counter)
            //{
            //    Console.WriteLine(myNumber);
            //    myNumber = myNumber * 2 + 1;
            //}
        }
    }
}
