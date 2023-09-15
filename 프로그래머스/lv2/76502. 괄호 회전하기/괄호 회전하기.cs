using System;
using System.Collections.Generic;

public class Solution {
    Stack<char> charStack = new Stack<char>();
    Stack<char> tmpStack = new Stack<char>();
    
    public bool isMatched(char left, char right)
    {
        return (left == '[' && right == ']') || (left == '{' && right == '}') || (left == '(' && right == ')');
    }
    
    public bool check(string s)
    {
        charStack.Clear();
        tmpStack.Clear();
        
        foreach (char c in s) {
            if (c == '[' || c == '{' || c == '(')
                charStack.Push(c);
            else if (charStack.Count == 0) return false;
            else if (isMatched(charStack.Pop(), c) == false) return false;
        }
        if (charStack.Count == 0) return true;
        return false;
    }
    
    public int solution(string s) {
        int answer = 0;
        for (int i = 0; i < s.Length; ++i)
            if (check(s.Substring(i, s.Length - i) + s.Substring(0, i)) == true) ++answer;
        
        return answer;
    }
}