using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1137N_thTribonacciNumber
    {
        public int Tribonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
            }
        }

        public int Tribonacci2(int n)
        {
            int[] sum = new int[5000];
            sum[0] = 0;
            sum[1] = 1;
            sum[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                sum[i] = sum[i - 1] + sum[i - 2] + sum[i - 3];
            }

            return sum[n];
        }
    }
}
