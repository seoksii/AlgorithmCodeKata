using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int ansRow = arr1.GetLength(0);
        int ansCol = arr2.GetLength(1);
        int len = arr1.GetLength(1);
        
        int[,] answer = new int[ansRow, ansCol];
        
        for (int i = 0; i < arr1.GetLength(0); ++i)
            for (int j = 0; j < arr2.GetLength(1); ++j)
                for (int k = 0; k < len; ++k)
                    answer[i, j] += arr1[i, k] * arr2[k, j];
        
        return answer;
    }
}