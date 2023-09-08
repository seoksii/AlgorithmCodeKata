using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        Dictionary<string, int> idx = new Dictionary<string, int>();
        Dictionary<string, List<string>> reported_history = new Dictionary<string, List<string>>();
        foreach (string id in id_list) {
            idx.Add(id, reported_history.Count);
            reported_history.Add(id, new List<string>());
        }
            
        
        foreach (string s in report) {
            string[] splitted = s.Split(' ');
            if (reported_history[splitted[1]].Contains(splitted[0]) == true) continue;
            reported_history[splitted[1]].Add(splitted[0]);
        }
        
        int[] answer = new int[id_list.Length];
        for (int i = 0; i < id_list.Length; ++i) {
            if (reported_history[id_list[i]].Count < k) continue;
            foreach (string reporter in reported_history[id_list[i]])
                ++answer[idx[reporter]];
        }
        
        
        return answer;
    }
}