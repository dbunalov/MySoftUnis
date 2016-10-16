using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace Exceptions
{
    class Exceptions
    {
        static void Main()
        {
            try
            {
                int paralel = int.Parse(Console.ReadLine());
                File.ReadAllText("output.txt");
            }
            catch (Exception fileNotFoundEx)
            {
                Console.WriteLine(fileNotFoundEx.Message);
            }
            finally
            {
                Console.WriteLine($"You are fucked up boy....");
            }
        }
    }
}
