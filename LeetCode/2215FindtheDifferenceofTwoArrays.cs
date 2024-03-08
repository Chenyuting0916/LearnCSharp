using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2215FindtheDifferenceofTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var result = new List<IList<int>>() { };
            result.Add(nums1.Except(nums2).ToList());
            result.Add(nums2.Except(nums1).ToList());

            return result.ToList();
        }   
    }
}
