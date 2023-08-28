using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        for (int i = 0; i <= t.Length - p.Length; ++i)
            if (string.Compare(t.Substring(i, p.Length), p) <= 0)
                ++answer;
        return answer;
    }
}