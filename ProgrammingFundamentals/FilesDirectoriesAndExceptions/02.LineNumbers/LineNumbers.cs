﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ArrayListDictionaries
{
    class Program
    {
        static void Main()
        {
            string[] file = File.ReadAllLines("input.txt");

            for (int i = 0; i < file.Length; i++)
            {
                    File.AppendAllText("output.txt", $"{i+1}. {file[i]}" + Environment.NewLine);
            }
        }
    }
}
