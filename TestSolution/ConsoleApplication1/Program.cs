using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a number for x");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Write a number for y");
            decimal y = decimal.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("|  Choose a option  |");
            Console.WriteLine("---------------------");
            Console.WriteLine("1 - (+) addition");
            Console.WriteLine("2 - (-) subtration ");
            Console.WriteLine("3 - (*) multification");
            Console.WriteLine("4 - (/) division");
            Console.WriteLine("Press Enter to exit the app");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x / y);
                    break;
            }
            Console.ReadKey(true);
        }
    }
}