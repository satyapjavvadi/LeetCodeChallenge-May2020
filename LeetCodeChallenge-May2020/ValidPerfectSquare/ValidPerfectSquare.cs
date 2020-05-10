using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    public class ValidPerfectSquare
    {
        public static void Test()
        {
            int num = 16;
            bool n = IsPerfectSquare(num);
            Console.WriteLine(n);
        }
        public static bool IsPerfectSquare(int num)
        {
            long low = 0;
            long high = num;

            long sq;

            while (low <= high)
            {
                long mid = (low + high) / 2;
                sq = mid * mid;

                if (sq == num)
                {
                    return true;
                }

                if (sq < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }
    }
}
