public class Solution {
    public long solution(int a, int b) {
        int min = a < b ? a : b;
        int max = a > b ? a : b;
        
        long answer = 0;
        for (int i = min; i <= max; i++)
            answer += i;
        
        return answer;
    }
}