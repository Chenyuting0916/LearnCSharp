namespace LeetCode;

public static class PalindromeNumber {
    public static bool IsPalindrome(int x) {
        var charArray = x.ToString().ToCharArray();
        Array.Reverse(charArray);
        return x.ToString() == new string(charArray);
    }
}