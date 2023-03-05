namespace LeetCode
{
    internal class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            //My solution is to use 費伯納西數列，但超時了..
            return GetFeb(n);

            //feb不用遞迴版本
            return Fibonacci(n + 1);

            //leetcode解 
            //Time complexity: O(N)
            //Space complexity: O(N)
            if (n == 1)
            {
                return 1;
            }
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

        static double A = Math.Sqrt(5) / 5;
        static double B = (1 + Math.Sqrt(5)) / 2;
        static double C = (1 - Math.Sqrt(5)) / 2;
        public static int Fibonacci(int n)
        {
            return (int)(A * (Math.Pow(B, n) - Math.Pow(C, n)));
        }



        public int GetFeb(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            return GetFeb(n - 1) + GetFeb(n - 2);
        }
    }
}
