using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;
        foreach (int i in numbers)
            answer -= i;
        return answer;
    }
}