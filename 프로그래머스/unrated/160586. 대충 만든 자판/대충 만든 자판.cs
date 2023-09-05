using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] minCost = new int[26];
        foreach (string s in keymap)
            for (int i = 0; i < s.Length; ++i)
                if (minCost[(int)(s[i] - 'A')] == 0) minCost[(int)(s[i] - 'A')] = i + 1;
                else if (i + 1 < minCost[(int)(s[i] - 'A')]) minCost[(int)(s[i] - 'A')] = i + 1;
        
        int[] answer = new int[targets.Length];
        
        for (int i = 0; i < targets.Length; ++i) {
            int cost = 0;
            foreach (char c in targets[i])
                if (minCost[(int)(c - 'A')] == 0) {
                    cost = -1;
                    break;
                }
                else cost += minCost[(int)(c - 'A')];
            answer[i] = cost;
        }
        
        return answer;
    }
}