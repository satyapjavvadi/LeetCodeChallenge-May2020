using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{

    public class Class1
    {
        public static void Test()
        {
            string num = "1432219";
            int k = 3;
            string str = RemoveKdigits(num, k);
            Console.WriteLine(str);
        }
        public static string RemoveKdigits(string num, int k)
        {
            if (k == 0)
            {
                return num;
            }
            if (num.Length == k)
            {
                return "0";
            }


            int n = num.Length;
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < n; i++)
            {
                while (st.Count != 0 && k > 0 && st.Peek() > num[i])
                {
                    st.Pop();
                    k--;
                }

                st.Push(num[i]);
            }

            while (k > 0)
            {
                st.Pop();
                k--;
            }

            string res = string.Empty;
            while (st.Count != 0)
            {
                res += st.Pop();
            }

            char[] ch = res.ToCharArray();
            Array.Reverse(ch);
            res = new string(ch);
            while (res.Length > 1 && res[0] == '0')
                res = res.Remove(0, 1);

            return res;

        }
    }
}
