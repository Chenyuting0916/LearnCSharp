namespace LeetCode;

public class RemoveElement
{
    public int Remove_Element(int[] nums, int val) {
        var a = nums.Where(x=>x != val).ToArray();
        for(var i = 0; i < a.Length; i++){
            nums[i] = a[i];
        }
        return a.Length;
    }
}