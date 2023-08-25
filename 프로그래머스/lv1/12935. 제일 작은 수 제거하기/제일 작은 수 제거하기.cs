using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        if (arr.Length == 1) return new int[1] {-1};
        
        int minIdx = 0;
        
        for (int i = 0; i < arr.Length; ++i)
            if (arr[i] < arr[minIdx])
                minIdx = i;
        
        List<int> answer = new List<int>();
        for (int i = 0; i < arr.Length; ++i)
            if (i != minIdx)
                answer.Add(arr[i]);
                
        return answer.ToArray();
    }
}