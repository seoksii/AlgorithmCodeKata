using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int i = 0, j = 0;
        while (i + j < goal.Length) {
            if (i < cards1.Length && cards1[i] == goal[i+j])
                ++i;
            else if (j < cards2.Length && cards2[j] == goal[i+j])
                ++j;
            else
                return "No";
        }
        
        return "Yes";
    }
}