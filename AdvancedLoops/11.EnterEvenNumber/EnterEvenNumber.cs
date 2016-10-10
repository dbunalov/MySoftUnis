using System;

namespace _11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }

            } while (true);
            Console.WriteLine($"Even number entered:{n}");
        }
            
    }
}