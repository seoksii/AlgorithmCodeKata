using System;

public class Solution {
    public int solution(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);
        
        int max = 0;
        for (int i = 0; i < citations.Length; ++i)
            if (i + 1 <= citations[i]) max = i + 1;
        return max;
    }
}