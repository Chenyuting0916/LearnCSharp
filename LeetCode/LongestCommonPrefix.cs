namespace LeetCode;

public class LongestCommonPrefix
{
    public string Longest_Common_Prefix(string[] strs) {
        if(strs.Length == 1)
            return strs[0];
        
        var prefixString = "";
        
        if (strs.Length == 0)
            return prefixString;
        
        // Go through all the letters of the first word
        for(int i = 0; i < strs[0].Length; i++){
            
            // Go through each of the remaining words
            foreach(string str in strs){
                // If i is higher then the length of the word
                // there is no longer a prefix to match
                if(i > str.Length - 1)
                    return prefixString;
                
                // If the i-th letter of the string doesn't match the i-th 
                // letter of the first word we've reached the end of the
                // common prefix
                if(strs[0][i] != str[i])
                    return prefixString;            
            }
            
            // If we make it through the inner foreach all of the 
            prefixString += strs[0][i];
        }
        
        
        return prefixString;
    }
}