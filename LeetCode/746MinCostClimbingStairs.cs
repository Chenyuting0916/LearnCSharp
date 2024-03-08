using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _746MinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            int[] dp = new int[n + 1];
            //min cost to climb to the n-th stair

            for (int i = 2; i <= n; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }

            return dp[n];
        }
    }
}
