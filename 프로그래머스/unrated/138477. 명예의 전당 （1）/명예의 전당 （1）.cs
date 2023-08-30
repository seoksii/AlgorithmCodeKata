using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        List<int> answer = new List<int>();
        int[] honor = new int[k];
        int idx = 0;
        
        for (int i = 0; i < score.Length; ++i) {
            for (int j = k - 1; j >= 0; --j)
                if (score[i] > honor[j]) {
                    if (j < k - 1) honor[j + 1] = honor[j];
                    idx = j;
                }
                else break;
            if (score[i] > honor[idx]) honor[idx] = score[i];
            if (i < k) answer.Add(honor[i]);
            else answer.Add(honor[k-1]);
        }
        
        return answer.ToArray();
    }
}