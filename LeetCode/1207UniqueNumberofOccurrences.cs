using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1207UniqueNumberofOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], 1);
                }
                else
                {
                    dic[arr[i]]++;
                }
            }
            var valueList = dic.Values.ToList();
            return valueList.Count == valueList.Distinct().Count();
        }
    }
}
