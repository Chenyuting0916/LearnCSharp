namespace LeetCode;

public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums) {
        var a = nums.Distinct().ToArray();
        for(int i = 0; i < a.Length; i++){
            nums[i] = a[i];
        }
        return a.Length;
    }
}