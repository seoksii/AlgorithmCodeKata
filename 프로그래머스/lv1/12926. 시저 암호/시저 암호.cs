using System;
using System.Text;

public class Solution {
    public string solution(string s, int n) {
        StringBuilder answer = new StringBuilder();
        
        foreach (char c in s)
            if (c == ' ')
                answer.Append(c);
            else if ((c >= 'a' && c <= 'z' - n) ||  (c >= 'A' && c <= 'Z' - n))
                answer.Append(Convert.ToChar(c + n));
            else
                answer.Append(Convert.ToChar(c + n - 1 + 'a' - 'z'));
        
        return answer.ToString();
    }
}