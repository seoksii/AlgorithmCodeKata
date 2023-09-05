using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int target = 1;
        int other = 0;
        char x = '\0';
        foreach (char c in s)
            if (x == '\0') x = c;
            else {
                if (c == x) ++target;
                else ++other;
                if (target == other) {
                    answer += 1;
                    target = 1;
                    other = 0;
                    x = '\0';
                }
            }
        if (x != '\0') answer += 1;
        
        return answer;
    }
}