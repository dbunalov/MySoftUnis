using System;


namespace _11.Numbers100To200
{
    class Numbers100To200
    {
        static void Main()
        {
            var numb = int.Parse(Console.ReadLine());

            if (numb < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (numb <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
                Console.WriteLine("Greater than 200");
        }
    }
}