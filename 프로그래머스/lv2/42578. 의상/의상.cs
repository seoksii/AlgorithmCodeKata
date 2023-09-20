using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        Dictionary<string, int> clothesDict = new Dictionary<string, int>();
        for (int i = 0; i < clothes.GetLength(0); ++i)
            if (clothesDict.ContainsKey(clothes[i,1])) ++clothesDict[clothes[i,1]];
            else clothesDict.Add(clothes[i,1], 2);
        
        int answer = 1;
        foreach(KeyValuePair<string, int> item in clothesDict)
            answer *= item.Value;
        
        return answer - 1;
    }
}