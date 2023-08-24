public class Solution {
    public int solution(int n) {
        int answer = 0;
        int k = 1;
        while (k * k < n) {
            if (n % k == 0)
                answer += k + (n / k);
            ++k;
        }
        
        if (k * k == n)
            answer += k;
        return answer;
    }
}