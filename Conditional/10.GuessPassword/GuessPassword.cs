using System;

namespace _10.GuessPassword
{
    class GuessPassword
    {
        static void Main()
        {
            string passw = Console.ReadLine();
            if (passw == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else if (passw != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
