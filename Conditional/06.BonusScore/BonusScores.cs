﻿using System;

namespace _06.BonusScore
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            var score = int.Parse(Console.ReadLine());
            var bonus = 0.0;

            if (score <= 100)
            {
                bonus = 5;
            }
            else if (score <= 1000)
            {
                bonus = score * 0.2;
            }
            else
            {
                bonus = score * 0.1;
            }
            if (score % 2 == 0)
            {
                bonus = bonus + 1;//bonus++
            }

            if (score % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(score + bonus);
        }
    }
}
