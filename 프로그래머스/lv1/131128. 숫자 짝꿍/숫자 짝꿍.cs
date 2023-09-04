using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        int[] cntX = new int[10];
        int[] cntY = new int[10];
        
        
        foreach (char c in X)
            ++cntX[c - '0'];
        foreach (char c in Y)
            ++cntY[c - '0'];
        
        StringBuilder answerBuilder = new StringBuilder();
        for (int i = 9; i >= 0; --i) {
            int cnt = cntX[i] > cntY[i] ? cntY[i] : cntX[i];
            for (int j = 0; j < cnt; ++j)
                answerBuilder.Append(i);
        }
        
        if (answerBuilder.Length == 0) answerBuilder.Append(-1);
        
        string answer = answerBuilder.ToString();
        
        foreach (char c in answer)
            if (c != '0') return answer;
        
        return "0";
    }
}