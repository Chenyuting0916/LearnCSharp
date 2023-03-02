namespace LeetCode;

public class SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target) {
        if(target < nums[0]) return 0;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] == target){
                return i;
            }
            if(i+1 < nums.Length && target > nums[i] && target < nums[i + 1] ){
                return i+1;
            }
        }
        return nums.Length;
    }
    
    public int BinarySearchInsert(int[] nums, int target) {
        int left = 0, right = nums.Length - 1, mid;
        while ( left <= right ){
            mid = (right + left) / 2;
            if ( nums[mid] < target ) left = mid + 1;
            else if ( nums[mid] > target ) right = mid - 1;
            else return mid;
        }   
        return left;
    }
}