using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _392IsSubsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            int sIndex = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s[sIndex])
                {
                    sIndex++;
                    if (sIndex == s.Length) return true;
                }
            }

            return sIndex == s.Length;
        }
    }
}
