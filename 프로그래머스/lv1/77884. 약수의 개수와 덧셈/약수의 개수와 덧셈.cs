using System;

public class Solution {
    int[] squares = new int[1000];
    int isSquare(int n)
    {
        if (squares[n-1] != 0) return squares[n-1];
        int i = 0;
        while (i * i < n) ++i;
        if (i * i == n) {
            squares[n-1] = 1;
            return 1;
        }
        squares[n-1] = -1;
        return -1;
    }
    
    public int solution(int left, int right) {
        Array.Clear(squares, 0, squares.Length);
        
        int answer = 0;
        
        for (int i = left; i <= right; ++i)
            if (isSquare(i) == 1)
                answer -= i;
            else
                answer += i;
        
        return answer;
    }
}