﻿using System;


namespace _03.SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");//if WriteLine it will written on ROWS not on Colums!!!
                }
                Console.WriteLine();
            }
            
        }
    }
}
