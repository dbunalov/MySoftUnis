using System;
using System.Linq;

namespace ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int i = arr.Length - 1; i >= 0; i--)//for (int i = n - 1; i >= 0; i--) n is still in the scope !!!
            {
                Console.Write(arr[i]);
                if (i > 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.WriteLine();
                }
            }
            //arr = arr.Reverse().ToArray();
            //Console.WriteLine(String.Join(" ", arr));
            
            //functional style
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).Reverse())); //
        }
    }
}
