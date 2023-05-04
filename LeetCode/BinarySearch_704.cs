namespace LeetCode
{
    internal class BinarySearch_704
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (right >= left)
            {
                int mid = (left + right) / 2;
                if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
