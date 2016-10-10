using System;

namespace LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // sheitanov
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            numbers[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    sum += numbers[j];
                }
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(" ", numbers));

        //    int n = int.Parse(Console.ReadLine()); // nakov
        //    int k = int.Parse(Console.ReadLine());

        //    var arr = new decimal[n];
        //    arr[0] = 1;
                      
        //    for (int i = 1; i < n; i++)
        //    {
        //        arr[i] = SumNums(arr, i - k, i - 1);
        //    }
        //    Console.WriteLine("Sequence:");
        //    Console.WriteLine(String.Join(" ", arr));
        //}

        //private static decimal SumNums(decimal[] arr,int startIndex, int endIndex)
        //{
        //    decimal sum = 0;
        //    for (int i = startIndex; i <= endIndex; i++)
        //    {
        //        if (i >= 0) 
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        }
    }
}
