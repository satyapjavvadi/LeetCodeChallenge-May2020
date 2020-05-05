using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    public class NumberComplement
    {
        public static void Test()
        {
            int num = 5;
            int res = FindComplement(num);
            Console.WriteLine(res);
        }
        public static int FindComplement(int num)
        {
            if (num == 1)
            {
                return 0;
            }
            int pow = 1;
            int temp = num;
            while (num > 0)
            {
                pow = pow * 2;
                num = num / 2;

            }
            return pow - temp - 1;
        }
    }
}
