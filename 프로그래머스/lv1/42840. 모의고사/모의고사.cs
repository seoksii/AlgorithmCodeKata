using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] supo1 = new int[] {1, 2, 3, 4, 5};
        int[] supo2 = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] supo3 = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        int cnt1 = 0, cnt2 = 0, cnt3 = 0;
        
        for (int i = 0; i < answers.Length; ++i) {
            if (answers[i] == supo1[i % supo1.Length]) ++cnt1;
            if (answers[i] == supo2[i % supo2.Length]) ++cnt2;
            if (answers[i] == supo3[i % supo3.Length]) ++cnt3;
        }
        
        if (cnt1 > cnt2 && cnt1 > cnt3) return new int[1] {1};
        else if (cnt2 > cnt1 && cnt2 > cnt3) return new int[1] {2};
        else if (cnt3 > cnt1 && cnt3 > cnt2) return new int[1] {3};
        else if (cnt1 == cnt2 && cnt1 > cnt3) return new int[2] {1,2};
        else if (cnt1 > cnt2 && cnt1 == cnt3) return new int[2] {1,3};
        else if (cnt1 < cnt2 && cnt2 == cnt3) return new int[2] {2,3};
        
        return new int[3] {1,2,3};
    }
}