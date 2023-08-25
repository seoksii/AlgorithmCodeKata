using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = (long)count * ((long)count + 1) / 2 * price - money;
        if (answer <= 0) return 0;
        return answer;
    }
}