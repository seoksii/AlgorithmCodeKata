using System;

public class Solution {
    public string solution(string s) {
        char[] charArr = s.ToCharArray();
        int cnt = 0;
        for (int i = 0; i < s.Length; ++i)
            if (charArr[i] == ' ') cnt = 0;
            else if (cnt++ % 2 == 0)
                charArr[i] = Char.ToUpper(charArr[i]);
            else
                charArr[i] = Char.ToLower(charArr[i]);
        
        return new string(charArr);
    }
}