using System;
using System.Linq;


namespace SalesReport
{
    class SalesReport
    {
        static void Main()
        {
            Sale[] sales = ReadSales();
            string[] towns = sales
                .Select(s => s.Town)
                .Distinct() //takes non repeatable 
                .OrderBy(t => t)
                .ToArray();

            foreach (string town in towns)
            {
                decimal salesByTown = sales
                                        .Where(s => s.Town == town)//searching towns
                                        .Select(s => s.Price * s.Quantity)
                                        .Sum();
                Console.WriteLine($"{town} -> {salesByTown:f2}");
            }

        }
        static Sale ReadSale()
        {
            string[] items = Console.ReadLine().Split(' ');
            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])
            };
        }

        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
    
}
