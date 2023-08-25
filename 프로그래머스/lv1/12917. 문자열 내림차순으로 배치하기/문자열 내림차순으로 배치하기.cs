using System;

public class Solution {
    public string solution(string s) {
        Char[] answer = s.ToCharArray();
        Array.Sort(answer);
        Array.Reverse(answer);
        return new string(answer);
    }
}