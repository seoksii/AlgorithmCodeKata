using System;
using System.Text;

public class Solution {
    public string solution(int[] food) {
        StringBuilder answer = new StringBuilder();

        for (int i = 1; i < food.Length; i++)
            for (int j = 0; j < food[i] / 2; j++)
                answer.Insert(answer.Length / 2, i.ToString() + i.ToString());
        
        answer.Insert(answer.Length / 2, 0.ToString());
        
        return answer.ToString();
    }
}