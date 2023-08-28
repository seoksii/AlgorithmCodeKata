using System;

public class Solution {
    public int solution(int n) {
        int num = 1;
        while (num * 3 <= n)
            num *= 3;
        
        int answer = 0;
        for (int i = num; i > 0; i /= 3) {
            answer += n / i * num / i;
            n %= i;
        }
            
        return answer;
    }
}