using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int offset = m * -1;
        int answer = 0;
        foreach (int i in section) {
            if (offset + m <= i) {
                offset = i;
                ++answer;
            }
        }
        return answer;
    }
}