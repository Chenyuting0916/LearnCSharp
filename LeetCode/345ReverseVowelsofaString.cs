using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _345ReverseVowelsofaString
    {
        public string ReverseVowels(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            Stack<char> needReverseVowels = new Stack<char>();
            for (var i = 0; i < sb.Length; i++)
            {
                if (vowels.Contains(sb[i]))
                {
                    needReverseVowels.Push(sb[i]);
                    Console.WriteLine(sb[i]);
                }
            }

            for (var i = 0; i < sb.Length; i++)
            {
                if (vowels.Contains(sb[i]))
                {
                    sb[i] = needReverseVowels.Pop();
                }
            }
            return sb.ToString(); ;
        }
    }
}
