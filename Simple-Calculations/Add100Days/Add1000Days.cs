using System;
using System.Globalization;

namespace Add1000Days
{
    class Add1000Days
    {
        static void Main(string[] args)
        {
            var DTG = Console.ReadLine();
            DateTime DTG1 = DateTime.ParseExact(DTG, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(DTG1.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}