using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    public class RansomeNote
    {
        public static void Test()
        {
            string ransomNote = "aa";
            string magazine = "aab";
            bool b = CanConstruct(ransomNote, magazine);
            Console.WriteLine(b);
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            char[] chRan = ransomNote.ToCharArray();
            char[] chMag = magazine.ToCharArray();

            Dictionary<char, int> dict1 = new Dictionary<char, int>();

            for (int i = 0; i < chMag.Length; i++)
            {
                if (!dict1.ContainsKey(chMag[i]))
                {
                    dict1.Add(chMag[i], 1);
                }
                else
                {
                    dict1[chMag[i]]++;
                }
            }

            for (int i = 0; i < chRan.Length; i++)
            {
                if (!dict1.ContainsKey(chRan[i]) || dict1[chRan[i]] == 0)
                {
                    return false;
                }
                else
                {
                    dict1[chRan[i]]--;
                }
            }

            return true;
        }
    }
}

