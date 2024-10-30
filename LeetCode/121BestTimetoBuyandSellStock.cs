using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _121BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int lowestPrice = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < lowestPrice)
                {
                    lowestPrice = prices[i];
                }
                else if (prices[i] - lowestPrice > maxProfit)
                {
                    maxProfit = prices[i] - lowestPrice;
                }
            }

            return maxProfit;
        }
    }
}
