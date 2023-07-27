using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _643MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var max = -Double.MaxValue;
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                sum += nums[i];

                if (i > k - 1)
                {
                    sum -= nums[i - k];
                }

                if (i >= k - 1)
                {
                    if (max < (double)sum / k)
                    {
                        max = (double)sum / k;
                    }
                }
            }

            return max;
        }
    }
}
