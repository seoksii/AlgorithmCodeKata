using System;

public class Solution {
    public int solution(int n) {
        int prev = 0;
        int cont = 1;
        for (int i = 2; i <= n; ++i) {
            int newNum = (prev + cont) % 1234567;
            prev = cont;
            cont = newNum;
        }
        return cont;
    }
}