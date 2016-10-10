using System;


namespace Point_In_The_Figure
{
    class Point_In_The_Figure
    {
        static void Main(string[] args)
        {
            var h1 = int.Parse(Console.ReadLine()); // exam hour
            var m1 = int.Parse(Console.ReadLine()); // exam mins
            var h2 = int.Parse(Console.ReadLine()); // arrive hour
            var m2 = int.Parse(Console.ReadLine()); // arrive mins

            var mm1 = m1 - 60;
            var mm2 = m2 - 60;

            if (h2 <= h1)
            {
                if (h1 == h2)
                {
                    var mm = m1 - m2;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before start", mm);
                    
                }
                else if (h1 > h2)
                {
                    var hh = h1 - h2;
                    var mm = m1 - m2;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1} hours before start", hh, mm);
                }
                
            }
            
            else if (h1 >= h2 && m1 >= m2 || h1 >= h2 && m1 <= m2 ) // early case

            {
                Console.WriteLine("On time");
                if (m1 > m2 && (m1 - m2) >=30 )
                {
                    Console.WriteLine("{0}:{1} minutes before start", h1 - h2, (m1 - mm2)-60);
                }
                else if (m1 < m2)
                {
                    Console.WriteLine("{0}:{1}", h1 - h2, (m2 - m1)-60);
                }
                else if ((h1 - h2) > 1)
                {
                    Console.WriteLine("");
                }
            }
            

        }
            
    }
}