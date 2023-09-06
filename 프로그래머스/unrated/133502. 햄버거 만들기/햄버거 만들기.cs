using System;
using System.Collections.Generic;

public class Solution {
    Stack<int> ingreStack = new Stack<int>();
    public bool check() {
        // check only when the peak is 1.
        if (ingreStack.Count < 4) return false;
        ingreStack.Pop();
        if (ingreStack.Peek() != 3) {
            ingreStack.Push(1);
            return false;
        }
        ingreStack.Pop();
        if (ingreStack.Peek() != 2) {
            ingreStack.Push(3);
            ingreStack.Push(1);
            return false;
        }
        ingreStack.Pop();
        if (ingreStack.Peek() != 1) {
            ingreStack.Push(2);
            ingreStack.Push(3);
            ingreStack.Push(1);
            return false;
        }
        ingreStack.Pop();
        return true;
    }
    
    public int solution(int[] ingredient) {
        int answer = 0;
        foreach (int i in ingredient) {
            ingreStack.Push(i);
            if (i == 1 && check() == true) ++answer;
        }
            
        return answer;
    }
}