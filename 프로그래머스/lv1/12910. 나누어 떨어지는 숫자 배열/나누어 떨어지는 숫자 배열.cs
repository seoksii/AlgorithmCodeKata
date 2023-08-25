using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answer = new List<int>();
        
        foreach(int n in arr)
            if (n % divisor == 0)
                answer.Add(n);
        
        if (answer.Count == 0) answer.Add(-1);
        answer.Sort();
        return answer.ToArray();
    }
}