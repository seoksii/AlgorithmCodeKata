using System;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int[] size = new int[10000000];
        int maxSize = 0;
        
        foreach (int t in tangerine) {
            ++size[t - 1];
            if (t > maxSize) maxSize = t;
        }
        
        Array.Sort(size, 0, maxSize);
        
        int answer = 0;
        for (int i = maxSize - 1; i >= 0; --i) {
            ++answer;
            k -= size[i];
            if (k <= 0) break;
        }
        
        return answer;
    }
}