using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _283MoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            var numbers = nums.Where(x => x != 0).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                nums[i] = numbers[i];
            }
            for (int i = numbers.Length; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        //other people's solution 
        public void MoveZeroes2(int[] nums)
        {
            int lastZeroPos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[lastZeroPos], nums[i]) = (nums[i], nums[lastZeroPos]);
                    lastZeroPos++;
                }
            }
        }
    }
}
