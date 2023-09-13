using System;

public class Solution {
    int GCD (int a, int b) {
        if (a % b == 0) return b;
        return GCD (b, a % b);
    }
    
    int LCM (int a, int b) {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        return min * max / GCD(max, min);
    }
    
    public int solution(int[] arr) {
        int answer = 1;
        foreach (int i in arr)
            answer = LCM(answer, i);
        return answer;
    }
}