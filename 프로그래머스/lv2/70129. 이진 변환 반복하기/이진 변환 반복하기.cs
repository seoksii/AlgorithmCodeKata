using System;

public class Solution {
    public int[] solution(string s) {
        int cnt0 = 0;
        int cnt1 = 0;
        foreach (char c in s)
            if (c == '1') ++cnt1;
            else ++cnt0;
        
        int cnt = 1;
        while (cnt1 > 1) {
            ++cnt;
            int newCnt = 0;
            while (cnt1 > 0) {
                if (cnt1 % 2 == 1) ++newCnt;
                else ++cnt0;
                cnt1 = cnt1 >> 1;
            }
            cnt1 = newCnt;
        }
        
        return new int[] {cnt, cnt0};
    }
}