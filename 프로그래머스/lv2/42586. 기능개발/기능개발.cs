using System;
using System.Collections.Generic;

public class Solution {
    public int GetRemainingDays(int progress, int speed) {
        int days = 0;
        while (progress < 100) {
            progress += speed;
            ++days;
        }
        return days;
    }
    
    public int[] solution(int[] progresses, int[] speeds) {
        Queue<(int, int)> progressQueue = new Queue<(int, int)>();
        List<int> answer = new List<int>();
        
        for (int i = 0; i < progresses.Length; ++i)
            progressQueue.Enqueue((progresses[i], speeds[i]));
        
        int days = 0;
        int cnt = 0;
        while (progressQueue.Count > 0) {
            (int progress, int speed) p = progressQueue.Dequeue();
            int remainingDays = GetRemainingDays(p.progress, p.speed);
            if (cnt == 0) days = remainingDays;
            if (remainingDays <= days) ++cnt;
            else {
                answer.Add(cnt);
                days = remainingDays;
                cnt = 1;
            }
        }
        if (cnt > 0) answer.Add(cnt);
        
        return answer.ToArray();
    }
}