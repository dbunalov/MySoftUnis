using System;

namespace BlankReceipt
{
    public class BlankReceipt
    {
        public static void ReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        public static void ReceiptBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        public static void RecepitFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        public static void Main()
    {
            ReceiptHeader();
            ReceiptBody();
            RecepitFooter();
    }
}
}