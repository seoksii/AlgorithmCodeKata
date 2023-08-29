using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        bool[] availableSums = new bool[201];
        for (int i = 0; i < numbers.Length - 1; ++i)
            for (int j = i + 1; j < numbers.Length; ++j)
                availableSums[numbers[i] + numbers[j]] = true;
        
        List<int> answer = new List<int>();
        for (int i = 0; i <= 200; ++i)
            if (availableSums[i] == true) answer.Add(i);
        return answer.ToArray();
    }
}