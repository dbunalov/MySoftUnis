using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double priceThreshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        double lastPrice = firstPrice;

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = GetpercentageDifference(lastPrice, currentPrice);    
            bool isSignificantDifference = IsSignificantDifference(difference, priceThreshold);
            string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);
            lastPrice = currentPrice;
            Console.WriteLine(message);
        }
    }

    private static string GetMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        return result;
    }

    private static bool IsSignificantDifference(double difference, double priceTreshold)
    {
        if (Math.Abs(difference) >= priceTreshold)
        {
            return true;
        }
        return false;
    }

    private static double GetpercentageDifference(double lastPrice, double currentPrice)
    {
        double percentageResult = (currentPrice - lastPrice) * lastPrice;       
        return percentageResult;
    }
}