using System.Text.Json;
using LeetCode;

Console.WriteLine(PalindromeNumber.IsPalindrome(123));



var nums = new int[]{1,1,2};
    var a = nums.Distinct().ToArray();
    nums = a;

Console.WriteLine(JsonSerializer.Serialize(nums));
