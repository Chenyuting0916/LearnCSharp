namespace LeetCode
{
    internal class Sqrt_x_
    {
        int mySqrt(int x)
        {
            return MySolution(x);
        }

        private static int MySolution(int x)
        {
            long expect = 1;
            while (expect * expect <= x)
            {
                expect++;
            }
            return (int)(expect - 1);
        }
    }
}
