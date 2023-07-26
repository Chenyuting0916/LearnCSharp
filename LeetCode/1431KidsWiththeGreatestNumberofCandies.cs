using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1431KidsWiththeGreatestNumberofCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            return candies.Select(x => x + extraCandies >= max).ToList();
        }
    }
}
