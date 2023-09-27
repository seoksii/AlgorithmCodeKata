using System;

public class Solution {
    int cal(string word, string s, int cnt, ref bool isAnswer) {
        if (word == s) {
            isAnswer = true;
            return cnt;
        }
        else if (s.Length == 5) return cnt;
        foreach (char c in "AEIOU") {
            cnt = cal(word, s + c, ++cnt, ref isAnswer);
            if (isAnswer) break;
        }
        return cnt;
    }
    
    public int solution(string word) {
        bool isAnswer = false;
        return cal(word, "", 0, ref isAnswer);
    }
}