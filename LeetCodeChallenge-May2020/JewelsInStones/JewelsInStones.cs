﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{ 
    class JewelsInStones
    {
        public static void Test()
        {
            string J = "aA";
            string S = "aAAbbbb";
            int count = NumJewelsInStones(J, S);

            Console.WriteLine(count);
        }
        public static int NumJewelsInStones(string J, string S)
        {
            char[] chJ = J.ToCharArray();
            char[] chS = S.ToCharArray();
            int count = 0;

            for (int i = 0; i < chJ.Length; i++)
            {
                for (int j = 0; j < chS.Length; j++)
                {
                    if (chJ[i] == chS[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
