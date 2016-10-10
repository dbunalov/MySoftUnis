using System;

namespace _19.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var p1 = 0.0;//<200
            var p2 = 0.0;//200 to 399
            var p3 = 0.0;//400 to 599
            var p4 = 0.0;//600 to 799
            var p5 = 0.0;//>=800

            for (int i = 1; i <= count; i++)
            {
                var numb = int.Parse(Console.ReadLine());
                if (numb < 200)
                {
                    p1++;
                }
                else if (numb < 400)
                {
                    p2++;
                }
                else if (numb < 600)
                {
                    p3++;
                }
                else if (numb < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            var p1count = p1 * 100.0 / count;
            var p2count = p2 * 100.0 / count;
            var p3count = p3 * 100.0 / count;
            var p4count = p4 * 100.0 / count;
            var p5count = p5 * 100.0 / count;

            Console.WriteLine("{0:F2}%", p1count);
            Console.WriteLine("{0:F2}%", p2count);
            Console.WriteLine("{0:F2}%", p3count);
            Console.WriteLine("{0:F2}%", p4count);
            Console.WriteLine("{0:F2}%", p5count);

        }
    }
}
