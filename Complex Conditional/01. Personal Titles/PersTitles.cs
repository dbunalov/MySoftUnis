using System;

namespace _01.Personal_Titles
{
    class PersTitles
    {
        static void Main()
        {

            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine().ToLower();

            if (age < 16)
            {
                if (sex == "m") Console.WriteLine("Master");
                else if (sex == "f") Console.WriteLine("Miss");
            }
            else
                if (sex == "m") Console.WriteLine("Mr.");
                else if (sex == "f") Console.WriteLine("Ms.");
                     
        }
    }
}
