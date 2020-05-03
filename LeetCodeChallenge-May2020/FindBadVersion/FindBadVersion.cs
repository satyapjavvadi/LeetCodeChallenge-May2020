using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    class FindBadVersion
    {
        public static void Test()
        {
            int[] arr = { 1, 2, 3, 4, 5};
            int n = arr.Length;
            
        }

        public static int FirstBadVersion(int[] arr)
        {

            int low = 1;
            int high = arr.Length;


            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == mid)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;
        }
    }
}
