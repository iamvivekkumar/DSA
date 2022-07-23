﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class BestTimeToBuyAndSellStock1
    {
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.

        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        //Example 1:
        //Input: prices = [7, 1, 5, 3, 6, 4]
        //Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        //Example 2:

        //Input: prices = [7,6,4,3,1]
        //Output: 0
        //Explanation: In this case, no transactions are done and the max profit = 0.
        public static int MaxProfit(int[] prices)
        {
            //Input: prices = [7, 1, 5, 3, 6, 4]
            //Output: 5

            int maxProfit = 0;
            int maxSoFar = prices[prices.Length - 1];

            for (int i = prices.Length - 2; i >= 0; i--)
            {
                if (maxSoFar - prices[i] > maxProfit)
                {
                    maxProfit = maxSoFar - prices[i];
                }

                maxSoFar = Math.Max(maxSoFar, prices[i]);
            }

            return maxProfit;
        }
    }
}
