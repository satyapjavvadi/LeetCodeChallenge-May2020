using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge_May2020
{
    class FloodFill
    {        
        public static void Test()
        {
            int x = 1;
            int y = 1;
            int newColor = 2;
            int[][] image = new int[][]
            {
               new int[] {1, 1, 1},
               new int[] {1, 1, 0},
               new int[] {1, 0, 1}
            };

            for(int i = 0; i < image.Length; i++)
            {
                for(int j = 0; j < image[0].Length; j++)
                {
                    Console.Write(image[i][j] +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            FloodFilled(image, x, y, newColor);

            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image[0].Length; j++)
                {
                    Console.Write(image[i][j]+ " ");
                }
                Console.WriteLine();
            }
        }
        public static int[][] FloodFilled(int[][] image, int sr, int sc, int newColor)
        {
            fill(image, sr, sc, image[sr][sc], newColor);
            return image;
        }

        public static void fill(int[][] image, int sr, int sc, int curColor, int newColor)
        {
            if (sr < 0 || sr >= image.Length ||
               sc < 0 || sc >= image[sr].Length ||
               image[sr][sc] != curColor || image[sr][sc] == newColor)
            {
                return;
            }

            image[sr][sc] = newColor;

            fill(image, sr, sc - 1, curColor, newColor);
            fill(image, sr, sc + 1, curColor, newColor);
            fill(image, sr - 1, sc, curColor, newColor);
            fill(image, sr + 1, sc, curColor, newColor);
        }
    }
}
