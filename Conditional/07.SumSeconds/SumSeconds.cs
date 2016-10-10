using System;

namespace _07.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
           
            var sum = num1 + num2 + num3;
            var min = 0;//var min = sum / 60; -- the smarter way
            var sec = 0;//var sec = sum % 60;

            if (sum <60)                            // -- in smarter way this is missing
            {                                       // -- in smarter way this is missing
                min = 0;                            // -- in smarter way this is missing
                sec = sum;                          // -- in smarter way this is missing
            }                                       // -- in smarter way this is missing
            else if (sum < 120)                     // -- in smarter way this is missing
            {                                       // -- in smarter way this is missing
                min = 1;                            // -- in smarter way this is missing
                sec = sum - 60;                     
            }
            else                                   // -- in smarter way this is missing
            {
                min = 2;                            // -- in smarter way this is missing
                sec = sum - 120;                    // -- in smarter way this is missing
            }                                       // -- in smarter way this is missing
            Console.Write("{0}:", min);
            if (sec < 10)
            {
                Console.Write("0");
            }
            Console.WriteLine(sec);
            //Console.WriteLine("{0}:{1}", minutes, seconds.ToString().PadLeft(2,'0')); easy way :)   
        }
    }
}
