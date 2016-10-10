using System;
using System.Collections.Generic;


namespace _081.MetricConvertor
{
    class MetricConverter2
    {
        static void Main(string[] args)
        {
            var size = double.Parse(Console.ReadLine());
            var sourceMetric = Console.ReadLine().ToLower();
            var destMetric = Console.ReadLine().ToLower();

            Dictionary<string, double> dict = new Dictionary<string, double>()
            {
                {"m", 1},
                {"mm", 1000},
                {"cm", 100},
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001},
                {"ft", 3.2808399},
                {"yd", 1.0936133}
            };

            var inputCoef = 1 / dict[sourceMetric];
            var outputCoef = dict[destMetric];
            var result = size * inputCoef * outputCoef;
            Console.WriteLine(result + " " + destMetric);
        }
    }
}
