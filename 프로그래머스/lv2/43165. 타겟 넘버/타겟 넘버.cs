using System;
using System.Collections.Generic;

public class Solution {
    int cal(int[] numbers, int target, int currentSum, int number, int cnt) {
        currentSum += number;
        ++cnt;
        if (cnt == numbers.Length)
            if (currentSum == target) return 1;
            else return 0;
        return cal(numbers, target, currentSum, numbers[cnt], cnt) + cal(numbers, target, currentSum, -numbers[cnt], cnt); 
    }
    
    public int solution(int[] numbers, int target) {
        return cal(numbers, target, 0, 0, -1);
    }
}