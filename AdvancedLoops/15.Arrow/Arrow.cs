using System;

class Arrow
{
    static void Main(string[] args)
    {
        Console.Write("Enter odd numbers only [3..79]: ");
        int n = int.Parse(Console.ReadLine());

        while (n % 2 == 0)
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Your number is not odd!");
            Console.Write("Enter odd numbers only [3..79]: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));//first row

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', n / 2), new string('.', n - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n - 2));
        
        for (int i = 1; i < n - 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', ((2 * n - 1) - 2 - 2 * i)));
            //outer points are equal to i; 
            //inside points are equal to (2 * n - 1) - 2 - 2*i due to all columns are (2*n - 1) 
            //  also we have 2 # (diez) and 2*i outer points
        }
        Console.WriteLine("{0}#{0}", new string('.', n - 1));
    }
}