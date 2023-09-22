using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        Queue<int> process = new Queue<int>();
        
        foreach (int priority in priorities)
            process.Enqueue(priority);
        
        Array.Sort(priorities);
        Array.Reverse(priorities);
        
        int answer = 0;
        
        while (process.Count > 0) {
            int priority = process.Dequeue();
            
            if (priorities[answer] > priority) {
                process.Enqueue(priority);
                if (location == 0) location = process.Count;
            }
            else {
                ++answer;
                if (location == 0) return answer;
            }
            
            --location;
        }
        
        return answer;
    }
}