using System;

public class Solution {
    public int solution(int n) {
        int i = 1;
        while (i < n)
            if (n % ++i == 1) return i;
        return i;
    }
}