﻿using System;


namespace _13.SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
                Console.WriteLine("extremely fast");
        }
    }
}