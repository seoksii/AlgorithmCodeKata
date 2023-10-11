using System;
using System.Collections.Generic;

public class Solution {    
    public int solution(int x, int y, int n) {
        if (x == y) return 0;
        Dictionary<int, int> DP = new Dictionary<int, int>();
        Queue<(int number, int order)> queue = new Queue<(int, int)>();
        queue.Enqueue((x, 0));
        DP.Add(x, 0);
        while (queue.Count > 0) {
            (int number, int order) result = queue.Dequeue();
            int candidate = result.number + n;
            int answer = result.order + 1;
            if (candidate == y) return answer;
            if (candidate < y && !DP.ContainsKey(candidate)) {
                queue.Enqueue((candidate, answer));
                DP.Add(candidate, answer);
            } 
            
            candidate = result.number << 1;
            if (candidate == y) return answer;
            if (candidate < y && !DP.ContainsKey(candidate)) {
                queue.Enqueue((candidate, answer));
                DP.Add(candidate, answer);
            } 
            
            candidate = result.number * 3;
            if (candidate == y) return answer;
            if (candidate < y && !DP.ContainsKey(candidate)) {
                queue.Enqueue((candidate, answer));
                DP.Add(candidate, answer);
            }
        }
        return -1;
    }
}