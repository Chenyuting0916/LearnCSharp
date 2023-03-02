namespace LeetCode;

public class LengthOfLastWord
{
    public int LengthOf_LastWord(string s) {
        var answer  = System.Text.RegularExpressions.Regex.Split(s, @" +");
        return answer.Last(x => x != string.Empty).Length;
    }
    
    public int LengthOf_LastWord2(string s) {
        return (s.TrimEnd()).Split(' ').Last().Length;
    }
}