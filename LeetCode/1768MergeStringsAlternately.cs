using System.Text;

namespace LeetCode
{
    internal class _1768MergeStringsAlternately
    {
        //my first version
        public string MergeAlternately(string word1, string word2)
        {
            if (word1.Length == 0)
            {
                return word2;
            }
            if (word2.Length == 0)
            {
                return word1;
            }

            var result = string.Empty;
            if (word1.Length > word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    result += word1[i];
                    result += word2[i];
                }
                result += word1.Substring(word2.Length);
                return result;
            }
            else
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    result += word1[i];
                    result += word2[i];
                }
                result += word2.Substring(word1.Length);
                return result;
            }
        }

        //most voted version
        public string MergeAlternately2(string word1, string word2)
        {
            StringBuilder res = new StringBuilder();
            int i = 0, j = 0;
            while (i < word1.Length && j < word2.Length)
            {
                res.Append(word1[i]).Append(word2[j]);
                i++;
                j++;
            }

            while (i < word1.Length)
            {
                res.Append(word1[i]);
                i++;
            }

            while (j < word2.Length)
            {
                res.Append(word2[j]);
                j++;
            }

            return res.ToString();
        }
    }
}
