using System;

namespace DataForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            var FName = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter your last name: ");
            var LName = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter your age: ");
            var Age = int.Parse(Console.ReadLine());
            Console.Write("Enter your SSN: ");
            var SSN = Console.ReadLine();
            Console.Write("Enter your place of birth: ");
            var POB = Console.ReadLine();
            Console.Write("Enter your date of birth: ");
            var DOB = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(@"
Thank you very much for the entered information!
Kindly request your attention with checking all info...
================================================================================");
            Console.WriteLine(@"First name  : {0}
Last name   : {1}
Age         : {2}
SSN         : {3}
POB         : {4}
DOB         : {5}
", FName, LName, Age, SSN, POB, DOB);

        }
    }
}
