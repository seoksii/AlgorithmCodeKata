using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, long left, long right) {
        List<int> answer = new List<int>();
        for (long i = left; i <= right; ++i) {
            long row = i / n + 1;
            long col = i % n + 1;
            answer.Add(Convert.ToInt32(Math.Max(row, col)));
        }
        return answer.ToArray();
    }
}