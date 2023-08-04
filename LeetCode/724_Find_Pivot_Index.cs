using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _724_Find_Pivot_Index
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum - leftSum - nums[i] == leftSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }

            return -1;
        }
    }
}
