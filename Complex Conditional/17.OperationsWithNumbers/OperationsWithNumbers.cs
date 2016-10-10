using System;


namespace _17.OperationsWithNumbers
{
    class OperationsWithNumbers
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var oper = Console.ReadLine();
            var resAdd = n1 + n2;       // +  
            var resSubs = n1 - n2;      // -
            var resMult = n1 * n2;      // *
            var resDiv = (double)n1 / n2;       // /
            var resMod = (double)n1 % n2;       // %
            string oddOrEven = "";
            switch (oper)
            {
                case "+":
                    if (resAdd % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, resAdd);
                    break;
                case "-":
                    if (resSubs % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, resSubs);
                    break;
                case "*":
                    if (resMult % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, resMult);
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} " + oper + " {1} = {2:0.00}", n1, n2, resDiv);
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} " + oper + " {1} = {2}", n1, n2, resMod);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}