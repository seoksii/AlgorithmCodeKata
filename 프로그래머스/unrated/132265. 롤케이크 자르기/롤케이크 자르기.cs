using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        Dictionary<int, int> left = new Dictionary<int, int>();
        Dictionary<int, int> right = new Dictionary<int, int>();
        foreach (int n in topping)
            if (!right.ContainsKey(n))
                right[n] = 1;
            else
                ++right[n];
        
        int answer = 0;
        foreach (int n in topping) {
            --right[n];
            if (right[n] == 0) right.Remove(n);
            if (!left.ContainsKey(n))
                left[n] = 1;
            else
                ++left[n];
            if (left.Count == right.Count)
                ++answer;
                
        }
        return answer;
    }
}