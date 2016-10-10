using System;

namespace _06.StopNumber
{
    class StopNumber
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());//first number
            var m = int.Parse(Console.ReadLine());//last number
            var s = int.Parse(Console.ReadLine());//stop number

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {                     
                        return;                        
                    }
                    Console.Write(i + " ");
                }
            }
        }
    }
}
