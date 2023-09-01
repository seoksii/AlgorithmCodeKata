using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int cnt = 0;
        int cnt0 = 0;
        foreach (int lotto_num in lottos) {
            if (lotto_num == 0) {
                ++cnt0;
                continue;
            }
            foreach (int win_num in win_nums) {
                if (lotto_num == win_num)
                    ++cnt;
            }
        }
        int max = 7 - cnt;
        if (max >= 7) max = 6;
        int min = 7 - (cnt0 + cnt);
        if (min >= 7) min = 6;
        return new int[2] {min, max};
    }
}