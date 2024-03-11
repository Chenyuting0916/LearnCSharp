using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _136SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
                else
                {
                    list.Remove(nums[i]);
                }
            }

            return list.First();
        }


        public int SingleNumber2(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
