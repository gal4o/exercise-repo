using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double significance = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double differance = GetPrecent(last, price);
            bool isSignificantDifference = HaveDif(differance, significance);
            string message = GetMessage(price, last, differance, isSignificantDifference);
            Console.WriteLine(message);
            last = price;
        }
    }

    private static string GetMessage(double price, double last, double differance, bool HaveDiff)
    {
        string to = "";
        if (differance == 0)
        {
            to = string.Format("NO CHANGE: {0}", price);
        }
        else if (!HaveDiff)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, differance*100);
        }
        else if (HaveDiff && (differance > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, differance*100);
        }
        else if (HaveDiff && (differance < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, differance*100);
        return to;
    }

    private static bool HaveDif(double significance, double differance)
    {
        if (Math.Abs(significance) >= differance)
        {
            return true;
        }
        return false;
    }

    private static double GetPrecent(double last, double price)
    {
        double precent = (price - last) / last;
        return precent;
    }
}
