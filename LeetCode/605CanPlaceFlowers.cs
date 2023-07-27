using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _605CanPlaceFlowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int plantableNumber = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if ((i + 1 > flowerbed.Length - 1) || flowerbed[i + 1] != 1)
                    {
                        if ((i - 1 < 0) || flowerbed[i - 1] != 1)
                        {
                            plantableNumber++;
                            flowerbed[i]++;
                        }
                    }
                }
            }
            return plantableNumber >= n;
        }
    }
}
