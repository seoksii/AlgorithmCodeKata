using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 1;
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        while (true) {
            min = (min + 1) / 2;
            max = (max + 1) / 2;
            if ( max == min ) return answer;
            answer++;
        }

        return answer;
    }
}