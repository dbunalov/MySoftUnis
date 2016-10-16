using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace FolderSize
{
    class FolderSize
    {
        static void Main()
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (string file in files)
            {
                FileInfo fInfo = new FileInfo(file);
                sum += fInfo.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
