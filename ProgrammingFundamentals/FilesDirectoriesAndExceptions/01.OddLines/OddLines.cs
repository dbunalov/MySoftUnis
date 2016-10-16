using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            string[] file = File.ReadAllLines("input.txt");

            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 != 0)
                {
                    File.AppendAllText("output.txt", file[i] + Environment.NewLine);
                }
            }
            //File.WriteAllLines("output.txt", file.Where(line, index) => index % 2 == 1));
        }
    }
}
