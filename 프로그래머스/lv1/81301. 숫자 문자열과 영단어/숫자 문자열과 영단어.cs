using System;
using System.Text;

public class Solution {
    public int solution(string s) {
        string[] strToNum = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        StringBuilder answer = new StringBuilder(s);
        for (int i = 0; i < 10; ++i)
            answer.Replace(strToNum[i], i.ToString());
        
        return Convert.ToInt32(answer.ToString());
    }
}