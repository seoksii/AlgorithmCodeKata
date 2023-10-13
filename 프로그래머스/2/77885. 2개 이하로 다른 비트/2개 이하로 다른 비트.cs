using System;
using System.Collections.Generic;

public class Solution {
    public long[] solution(long[] numbers) {
        List<long> answer = new List<long>();
        foreach (long n in numbers) {
            if (n % 2 == 0)
                answer.Add(n + 1);
            else {
                long basis = 1;
                while ((n / basis) % 2 != 0)
                    basis = basis << 1;
                
                answer.Add(n + (basis >> 1));
            }
        }
        return answer.ToArray();
    }
}