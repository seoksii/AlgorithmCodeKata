using System;

public class Solution {
    int[,] Dungeons;
    bool[] isIn;
    int maxCnt;
    
    void cal(int k, int idx, int n) {
        if (n != 0) {
            if (k < Dungeons[idx,0]) return;
            k -= Dungeons[idx,1];
            if (n > maxCnt) maxCnt = n;
        }
        for (int i = 0; i < isIn.Length; ++i)
            if (!isIn[i]) {
                isIn[i] = true;
                cal(k, i, n + 1);
                isIn[i] = false;
            }
    }
    
    public int solution(int k, int[,] dungeons) {
        Dungeons = dungeons;
        isIn = new bool[dungeons.GetLength(0)];
        cal(k, 0, 0);
        return maxCnt;
    }
}