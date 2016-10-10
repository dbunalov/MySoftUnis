using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class MyTestApp
    {
        static void Main(string[] args)
        {
            int yyy = 2016;
            Console.WriteLine("Today's date: {0:D}", DateTime.Now);
            Console.WriteLine("");
            Console.WriteLine("Hello mate, kindly request some of this info");
            Console.Write("Enter your name pls: ");
            string name = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            int yob = yyy - age;
            Console.Write("Enter your day of birth: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter your month of birth: ");
            int mmm = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine(" " + name + " Your DOB is: {0}", day + "." + mmm + "." + yob);
            Console.WriteLine("=====================================================");
            Console.Write("Is that info correct (1=correct / 2=not correct)? ");
            int ans = int.Parse(Console.ReadLine());
             
            if (ans <= 1)//HERE WE CHECK YOUR ANSWER
            {
                Console.Clear();
                Console.WriteLine(@"OK
============================================================================
Thank you very much for that information. Keep in mind to update it ASAP
there's any changes!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(@"ASAP NEW INFO
==============================================================================
Please provide us with the correct information with restarting the application
and enter the correct info!");
                Console.Beep(432, 300);
            }
        }
    }
}
