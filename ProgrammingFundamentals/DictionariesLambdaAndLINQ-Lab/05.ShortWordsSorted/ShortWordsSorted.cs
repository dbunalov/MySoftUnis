using System;
using System.Linq;


namespace ArrayListDictionaries
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length <5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();
            
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
