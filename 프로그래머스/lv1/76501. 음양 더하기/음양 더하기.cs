using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        
        for (int i = 0; i < absolutes.Length; ++i)
            answer += (signs[i] ? 1 : -1) * absolutes[i];
        return answer;
    }
}