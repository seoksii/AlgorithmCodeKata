using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxX = int.MinValue;
        int maxY = int.MinValue;
        for (int i = 0; i < sizes.GetLength(0); ++i)
        {
            if (sizes[i, 0] < sizes[i, 1]) {
                int tmp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = tmp;
            }
            if (sizes[i, 0] > maxX) maxX = sizes[i, 0];
            if (sizes[i, 1] > maxY) maxY = sizes[i, 1];
        }
            
        return maxX * maxY;
    }
}