using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _338CountingBits
    {
        public int[] myCountBits(int n)
        {
            var answer = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                var current = i;
                while (current > 0)
                {
                    if (current % 2 == 1) count++;
                    current = current / 2;
                }
                answer[i] = count;
            }

            return answer;
        }

        public int[] CountBits(int n)
        {
            int[] ans = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                ans[i] = ans[i >> 1] + (i & 1);
            }
            return ans;
        }

        public int[] CountBits2(int n)
        {
            int[] list1 = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                int sum = CountOnesInBinary(i);
                list1[i] = sum;
            }
            return list1;
        }

        private int CountOnesInBinary(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }
            return count;
        }
    }
}
