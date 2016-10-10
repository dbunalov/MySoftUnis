using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class SmallShop
    {
        static void Main()
        {
            
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var result = 0.0;

            Dictionary<string, double> sofia = new Dictionary<string, double>() 
            {
                { "coffee", 0.50},
                { "water", 0.80},
                { "beer", 1.20},
                { "sweets", 1.45},
                { "peanuts", 1.60}
            };
            // Sofia               0.50    0.80    1.20    1.45    1.60
            Dictionary<string, double> plovdiv = new Dictionary<string, double>()
            {
                { "coffee", 0.40},
                { "water", 0.70},
                { "beer", 1.15},
                { "sweets", 1.30},
                { "peanuts", 1.50}
                           // Plovdiv             0.40    0.70    1.15    1.30    1.50

            };
            Dictionary<string, double> varna = new Dictionary<string, double>() //
            {
                { "coffee", 0.45},
                { "water", 0.70},
                { "beer", 1.10},
                { "sweets", 1.35},
                { "peanuts", 1.55}
           // Varna               0.45    0.70    1.10    1.35    1.55
            };

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    result = quantity * sofia[product];
                }
                else if (product == "water")
                {
                    result = quantity * sofia[product];
                }
                else if (product == "beer")
                {
                    result = quantity * sofia[product];
                }
                else if (product == "sweets")
                {
                    result = quantity * sofia[product];
                }
                else
                {
                    result = quantity * sofia[product];
                }
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    result = quantity * plovdiv[product];
                }
                else if (product == "water")
                {
                    result = quantity * plovdiv[product];
                }
                else if (product == "beer")
                {
                    result = quantity * plovdiv[product];
                }
                else if (product == "sweets")
                {
                    result = quantity * plovdiv[product];
                }
                else
                {
                    result = quantity * plovdiv[product];
                }
            }
            else
            {
                if (product == "coffee")
                {
                    result = quantity * varna[product];
                }
                else if (product == "water")
                {
                    result = quantity * varna[product];
                }
                else if (product == "beer")
                {
                    result = quantity * varna[product];
                }
                else if (product == "sweets")
                {
                    result = quantity * varna[product];
                }
                else
                {
                    result = quantity * varna[product];
                }
            }
            Console.WriteLine(result);
        }
    }
}
