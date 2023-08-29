using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int?[] positions = new int?[26];
        List<int> answer = new List<int>();
        
        for (int i = 0; i < s.Length; ++i) {
            if (positions[s[i] - 'a'] == null)
                answer.Add(-1);
            else
                answer.Add(i - (int)positions[s[i] - 'a']);
            positions[s[i] - 'a'] = (int?)i;
        }
        
        return answer.ToArray();
    }
}