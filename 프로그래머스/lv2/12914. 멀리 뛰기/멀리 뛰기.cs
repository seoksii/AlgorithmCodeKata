using System;

public class Solution {
    public long solution(int n) {
        int[] DP = new int[2000];
        DP[0] = 1;
        DP[1] = 2;
        for (int i = 2; i < n; ++i)
            DP[i] = (DP[i - 2] + DP[i - 1]) % 1234567;
        
        return Convert.ToInt64(DP[n - 1]);
    }
}