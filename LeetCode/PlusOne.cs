namespace LeetCode;

public class PlusOne
{
    public int[] Plus_One(int[] digits) {
        if(digits.Last() != 9){
            digits[digits.Length - 1]++;
            return digits;
        }

        for(int i = digits.Length - 1; i >= 0; i--){
            if(i-1 >= 0 && digits[i]+1 ==10 && digits[i-1] != 9){
                digits[i] = 0;
                digits[i-1]++;
                return digits;
            }
            digits[i] = 0;
        }
        var result = new int[]{1};
        return result.Concat(digits).ToArray();
    }
}