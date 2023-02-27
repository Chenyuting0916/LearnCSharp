namespace LeetCode;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        return Solution1(s);
    }

    private static int Solution1(string s)
    {
        var romanNumberMapping = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var result = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && romanNumberMapping[s[i]] < romanNumberMapping[s[i + 1]])
            {
                result -= romanNumberMapping[s[i]];
            }
            else
            {
                result += romanNumberMapping[s[i]];
            }
        }

        return result;
    }
}