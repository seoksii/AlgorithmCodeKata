using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] todays = Array.ConvertAll(today.Split('.'), int.Parse);
        Dictionary<char, int> termDict = new Dictionary<char, int>();
        
        // Convert String Array into Dictionary
        foreach(string s in terms) {
            string[] t = s.Split(" ");
            termDict.Add(t[0][0], Convert.ToInt32(t[1]));
        }
        
        List<int> answer = new List<int>();
        for (int i = 0; i < privacies.Length; ++i) {
            string[] p = privacies[i].Split(' ');
            int[] d = Array.ConvertAll(p[0].Split('.'), int.Parse);
            if ((todays[0] - 2000) * 12 * 28 + todays[1] * 28 + todays[2]
                >= (d[0] - 2000) * 12 * 28 + d[1] * 28 + d[2] + termDict[p[1][0]] * 28) answer.Add(i + 1);
        }
        
        return answer.ToArray();
    }
}