using System;

class PrintPartOfASCIITable
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int stopNum = int.Parse(Console.ReadLine());

        for (int i = startNum; i <= stopNum; i++)
        {
            Console.Write(Convert.ToChar(i)+" ");            
        }
        Console.WriteLine();
    }
}