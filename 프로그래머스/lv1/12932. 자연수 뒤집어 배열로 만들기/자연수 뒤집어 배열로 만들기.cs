using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(long n) {
        List<int> answer = new List<int>();
        while (n > 0) {
            answer.Add((int)(n % 10));
            n /= 10;
        }
        return answer.ToArray();
    }
}