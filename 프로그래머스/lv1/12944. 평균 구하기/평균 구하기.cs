using System;

public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        foreach (int i in arr)
            answer += Convert.ToDouble(i);
        return answer / Convert.ToDouble(arr.Length);
    }
}