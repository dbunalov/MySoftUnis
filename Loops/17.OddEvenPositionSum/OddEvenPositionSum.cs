using System;

namespace _17.OddEvenPositionSum
{
    class OddEvenPositionSum
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sumOdd = 0.0;
            var sumEven = 0.0;
            var minOdd = double.MaxValue;
            var maxOdd = double.MinValue;
            var minEven = double.MaxValue;
            var maxEven = double.MinValue;


            for (int i = 1; i <= count; i++)//Odd Even Sum
            {
                var number = double.Parse(Console.ReadLine());


                if (i % 2 == 0)//odd even sums
                {
                    sumEven += number;
                    if (number > maxEven)//max even
                    {
                        maxEven = number;
                    }
                    if (number < minEven)//min even
                    {
                        minEven = number;
                    }
                }
                else
                {
                    sumOdd += number;
                    if (number > maxOdd)//max odd
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)//min odd
                    {
                        minOdd = number;
                    }
                }
            }

            Console.WriteLine("OddSum={0},", sumOdd);

            Console.WriteLine("OddMin={0}", minOdd == double.MaxValue ? "No" : minOdd.ToString());//minOdd.ToString() -- because "No" is string!!!
            //if (minOdd == double.MaxValue)
            //{
            //    Console.WriteLine("OddMin=No");
            //
            //}
            //else
            //{
            //    Console.WriteLine("OddMin={0},", minOdd);
            //}

            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");

            }
            else
            {
                Console.WriteLine("OddMax={0},", maxOdd);
            }
            Console.WriteLine("EvenSum={0},", sumEven);


            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");

            }
            else
            {
                Console.WriteLine("EvenMin={0},", minEven);

            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");

            }
            else
            {
                Console.WriteLine("EvenMax={0}", maxEven);

            }
        }
    }
}