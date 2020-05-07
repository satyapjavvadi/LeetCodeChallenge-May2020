using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    class MajorityElement
    {
        public static void Test()
        {
            int[] arr = { 3, 2, 3 };
            int a = MajorityElementinArray(arr);
            Console.WriteLine(a);
        }
        public static int MajorityElementinArray(int[] nums)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int res = 0;
            int arrlen = nums.Length / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]]++;
                }

                if (dict[nums[i]] > arrlen)
                {
                    res = nums[i];
                }

            }

            return res;
        }
    }
}
