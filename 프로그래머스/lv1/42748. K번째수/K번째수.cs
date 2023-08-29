using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        List<int> sliced = new List<int>();
        List<int> answer = new List<int> {};
        for (int i = 0; i < commands.GetLength(0); ++i) {
            sliced.Clear();
            sliced.AddRange(array.Skip(commands[i,0] - 1).Take(commands[i,1] - commands[i,0] + 1));
            sliced.Sort();
            answer.Add(sliced[commands[i,2] - 1]);
        }
        
        return answer.ToArray();
    }
}