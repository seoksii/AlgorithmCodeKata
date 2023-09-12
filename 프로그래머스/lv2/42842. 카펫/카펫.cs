using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int total = brown + yellow;
        
        for (int i = 3; i <= total; ++i) {
            for (int j = 3; j <= i; ++j) {
                if ((i - 2) * (j - 2) == yellow && i * j == total)
                    return new int[2] {i, j};
            }
        }
        int[] answer = new int[] {};
        return answer;
    }
}