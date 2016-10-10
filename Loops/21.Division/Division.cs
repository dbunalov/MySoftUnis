using System;


namespace _21.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var p1 = 0.0;//% 2
            var p2 = 0.0;//% 3
            var p3 = 0.0;//% 4

            for (int i = 0; i < count; i++)
            {
                var numb = int.Parse(Console.ReadLine());
                if (numb % 2 == 0)
                {
                    p1++;
                }
                if (numb % 3 == 0)
                {
                    p2++;
                }
                if (numb % 4 == 0)
                {
                    p3++;
                }
            }
            var p1count = p1 * 100.0 / count;
            var p2count = p2 * 100.0 / count;
            var p3count = p3 * 100.0 / count;

            Console.WriteLine("{0:F2}%", p1count);
            Console.WriteLine("{0:F2}%", p2count);
            Console.WriteLine("{0:F2}%", p3count);
        }
    }
}
