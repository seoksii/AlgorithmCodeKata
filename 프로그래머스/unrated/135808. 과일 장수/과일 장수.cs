using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int[] costs = new int[k+1];
        
        foreach (int i in score) {
            ++costs[i];
        }
        
        int answer = 0;
        for (int i = k; i > 0; --i) {
            answer += costs[i] / m * m * i;
            costs[i - 1] += costs[i] % m;
        }
        return answer;
    }
}