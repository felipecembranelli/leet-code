// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

public static class BuySellStock
{


    // O(N)
    public static int Calculate(int[] prices)
    {

        int buyPrice = prices[0];
        int SellPrice = 0;
        int buyDay = 1;
        int profit = 0;


        int currentPrice = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            currentPrice = prices[i];

            if (currentPrice < buyPrice)
            {
                buyPrice = currentPrice;
                buyDay = i + 1;
            }

            if ((currentPrice > SellPrice) && ((i + 1) > buyDay))
                SellPrice = currentPrice;

            profit = (SellPrice - buyPrice) > 0 ? (SellPrice - buyPrice) : 0;
        }

        return profit;
    }

    /// <summary>
    /// more elegant solution
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    /// 
    // O(n)
    public static int Calculate2(int[] prices)
    {
        if (prices.Length == 0) return 0;

        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            max = Math.Max(max, prices[i] - min);
        }

        return max;
    }

    // O(n)
    public static int Calculate3(int[] prices)
    {
        int min = prices[0];
        int max = 0;

        for (int i=1; i< prices.Length; i++)
        {
            if (min < prices[i])
            {
                min = prices[i];
            }
            else if ((prices[i] - min) > max) {
                max = prices[i] - min;
            }
        }

        return max;
               



    }

}
    