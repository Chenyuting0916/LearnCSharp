using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _374GuessNumberHigherorLower
    {

        //public class Solution : GuessGame
        //{
        //    public int GuessNumber(int n)
        //    {
        //        int low = 1;
        //        int high = n;

        //        // Loop until low and high pointers meet
        //        while (low <= high)
        //        {
        //            // Find the middle point
        //            int mid = low + (high - low) / 2;

        //            // Call the pre-defined API to get feedback
        //            int result = guess(mid);

        //            // Check if we have found the answer
        //            if (result == 0)
        //            {
        //                return mid;
        //            }

        //            // Check if we need to search in the left half
        //            else if (result == -1)
        //            {
        //                high = mid - 1;
        //            }

        //            // Check if we need to search in the right half
        //            else
        //            {
        //                low = mid + 1;
        //            }
        //        }

        //        // Return -1 if no answer is found
        //        return -1;
        //    }
        //}
    }


}
