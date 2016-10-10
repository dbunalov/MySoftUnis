using System;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("**");
                return;
            }
            int dashes;
            int stars;
            int rows = n;
            int inlineDashes;

            if (n % 2 == 0)
            {
                dashes = n / 2 - 1;
                inlineDashes = 2;
                stars = 2;
                rows = n /2 - 1;
            }
            else
            {
                dashes = n / 2;
                stars = 1;
                inlineDashes = 1;
                rows = n / 2;
            }
            string firstLine = String.Format("{0}{1}{0}", new string('-', dashes), new string('*', stars));//first row

            Console.WriteLine(firstLine);
            for (int i = 0; i < rows; i++)
            {
                if (dashes > 0)
                {
                    dashes--;
                }
                string nextLine = String.Format("{0}*{1}*{0}", new string('-', dashes), new string('-', inlineDashes));
                Console.WriteLine(nextLine);
                //Console.Write(new string('-', dashes));
                //Console.Write(new string('*', 1));
                //Console.Write(new string('-', inlineDashes));
                //Console.Write(new string('*', 1));
                //Console.WriteLine(new string('-', dashes));
                inlineDashes += 2;
            }
            for (int i = 0; i < rows - 1; i++)
            {
                inlineDashes -= 2;
                string nextLine2 = String.Format("{0}*{1}*{0}", new string('-', i + 1), new string('-', inlineDashes - 2));
                Console.WriteLine(nextLine2);
                //Console.Write(new string('-', i + 1));
                //Console.Write("*");
                //Console.Write(new string('-', inlineDashes-2));
                //Console.Write("*");
                //Console.Write(new string('-', i + 1));
                //Console.WriteLine();                
            }
            Console.WriteLine(firstLine);           
        }
    }
}