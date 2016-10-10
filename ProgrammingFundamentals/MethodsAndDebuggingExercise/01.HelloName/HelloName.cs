using System;

namespace HelloName
{
    public class HelloName
    {
        public static void GetName(string name)
        {
            string enteredName = Console.ReadLine();
            Console.WriteLine($"Hello, {enteredName}!");
        }
        public static void Main()
        {
            string name = string.Empty;
            GetName(name);
        }
    }
}
