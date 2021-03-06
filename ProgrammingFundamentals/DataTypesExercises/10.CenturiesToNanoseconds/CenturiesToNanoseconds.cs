﻿using System;
using System.Numerics;
class CenturiesToNanoseconds
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        //decimal minutes = hours * 60;
        //decimal seconds = minutes * 60;
        //decimal millisecods = seconds * 1000;
        //decimal microseconds = millisecods * 1000;
        //decimal nanoseconds = microseconds * 1000;

        long minutes = hours * 60;
        long seconds = minutes * 60;
        long millisecods = seconds * 1000;
        long microseconds = millisecods * 1000;
        BigInteger nanoseconds = BigInteger.Multiply(microseconds,1000);

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {millisecods} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}