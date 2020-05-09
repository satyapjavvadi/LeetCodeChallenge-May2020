using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    public class CheckIsaStraightLine
    {
        public static void Test()
        {
            int[][] arr = new int[][] { new int[] {1, 2},
                                        new int[] {2, 3},
                                        new int[] {3, 4},
                                        new int[] {4, 5},
                                        new int[] {5, 6},
                                        new int[] {6, 7}};
            bool b = CheckStraightLine(arr);
            Console.WriteLine(b);
        }
        public static bool CheckStraightLine(int[][] coordinates)
        {

            decimal x1 = coordinates[0][0];
            decimal y1 = coordinates[0][1];
            decimal x2 = coordinates[1][0];
            decimal y2 = coordinates[1][1];
            decimal slope;

            if (x2 == x1)
            {
                slope = (y2 - y1);
            }
            else
            {
                slope = (y2 - y1) / (x2 - x1);
            }

            for (int i = 2; i < coordinates.Length; i++)
            {
                x1 = coordinates[i - 1][0];
                y1 = coordinates[i - 1][1];
                x2 = coordinates[i][0];
                y2 = coordinates[i][1];

                decimal currentSlope;

                if (x2 == x1)
                {
                    currentSlope = (y2 - y1);
                }
                else
                {
                    currentSlope = (y2 - y1) / (x2 - x1);
                }

                if (currentSlope != slope)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
