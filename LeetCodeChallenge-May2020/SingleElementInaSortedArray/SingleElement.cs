﻿using System;

public class SingleElement
{
    public static void Test()
    {
        int[] nums = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
        int n = SingleNonDuplicate(nums);
        Console.WriteLine(n);
    }

    public static int SingleNonDuplicate(int[] nums)
    {

        int low = 0;
        int high = nums.Length - 1;
        int mid = 0;

        if (high == 0)
        {
            return nums[0];
        }
        else if (nums[0] != nums[1])
        {
            return nums[0];
        }
        else if (nums[high] != nums[high - 1])
        {
            return nums[high];
        }

        while (low <= high)
        {
            mid = (low + high) / 2;

            if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
            {
                return nums[mid];
            }

            if (((mid % 2) == 0 && nums[mid] == nums[mid + 1]) || ((mid % 2) == 1 && nums[mid] == nums[mid - 1]))
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;
    }
}
