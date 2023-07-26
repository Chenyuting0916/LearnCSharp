using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class _1071GreatestCommonDivisorofStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 == "") return "";
            if (str2 == "") return "";
            if (str2 == str1) return str1;

            for (int i = 0; i <= str1.Length; i++)
            {
                if (
                (str1.Length - i) != 0 &&
                str2.Contains(str1.Substring(0, str1.Length - i)) &&
                (str2.Length % (str1.Length - i)) == 0 &&
                (str1.Length % (str1.Length - i)) == 0 &&
                !str1.Replace(str1.Substring(0, str1.Length - i), "").Any() &&
                !str2.Replace(str1.Substring(0, str1.Length - i), "").Any()
                 )
                {
                    Console.WriteLine(str2);
                    Console.WriteLine(str1.Substring(0, str1.Length - i));

                    Console.WriteLine(JsonSerializer.Serialize(!str2.Replace(str1.Substring(0, str1.Length - i), "").Any()));
                    return str1.Substring(0, str1.Length - i);
                }
            }

            return "";
        }
    }
}
