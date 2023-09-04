using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int[] status = new int[n+2];
        foreach (int i in reserve)
            status[i] = 1;
        foreach (int i in lost)
            if (status[i] == 1) status[i] = -1;
        
        Array.Sort(lost);
        
        int answer = n;
        foreach (int i in lost)
            if (status[i - 1] == 1) status[i - 1] = 0;
            else if (status[i + 1] == 1) status[i + 1] = 0;
            else if (status[i] != -1) --answer;

        return answer;
    }
}