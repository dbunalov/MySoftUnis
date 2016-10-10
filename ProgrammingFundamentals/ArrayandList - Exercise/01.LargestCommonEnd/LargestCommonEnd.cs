using System;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            int commonElementsLeft = 0;
            int commonElementsRight = 0;

            int shorterLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < shorterLength; i++)
            {
                if (first[i] == second[i])
                {
                    commonElementsLeft++;
                    continue;
                }
                break;
            }

            //Console.WriteLine(commonElementsLeft);

            Array.Reverse(first);
            Array.Reverse(second);

            for (int i = 0; i < shorterLength; i++) // if array.reverse is not used => for (int i = 1; i = shorterLength; i++)
            {
                if (first[i] == second[i])          //                 => if (first[first.Length -i] == second[second.Length - i]
                {
                    commonElementsRight++;
                    continue;
                }
                break;
            }
            Console.WriteLine(Math.Max(commonElementsLeft, commonElementsRight));
        }
    }
}
