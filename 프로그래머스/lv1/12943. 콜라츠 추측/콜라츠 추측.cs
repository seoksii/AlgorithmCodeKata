public class Solution {
    public int solution(int num) {
        if (num == 1) return 0;
        
        int answer = 0;
        long longNum = (long)num;
        while (answer < 500) {
            if (longNum % 2 == 0)
                longNum /= 2;
            else
                longNum = longNum * 3 + 1;
            ++answer;
            if (longNum == 1) break;
        }
        
        if (longNum != 1) return -1;
        
        return answer;
    }
}