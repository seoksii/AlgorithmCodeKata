using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        bool[] isSkipped = new bool[26];
        foreach (char c in skip)
            isSkipped[(int)(c - 'a')] = true;
        
        List<char> charList = new List<char>();
        List<int> order = new List<int>();
        char candidate = 'a';
        int orderCount = 0;
        foreach (bool b in isSkipped) {
            if (b == false) { 
                charList.Add(candidate);
                order.Add(orderCount++);
            }
            else order.Add(orderCount);
            ++candidate;
        }
        
        StringBuilder answer = new StringBuilder();
        foreach (char c in s)
            answer.Append(charList[(order[(int)(c - 'a')] + index) % charList.Count]);
        
        return answer.ToString();
    }
}