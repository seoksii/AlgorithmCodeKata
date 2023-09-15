using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        Dictionary<int, bool> answer = new Dictionary<int, bool>();
        
        for (int i = 0; i < elements.Length; ++i) {
            int partialSum = 0;
            for (int j = 0; j < elements.Length; ++j) {
                partialSum += elements[(i + j) % elements.Length];
                if (answer.ContainsKey(partialSum) == false) answer.Add(partialSum, true);
            }
        }
            
        
        return answer.Count;
    }
}