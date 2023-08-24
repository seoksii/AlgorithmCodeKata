public class Solution {
    public bool solution(int x) {
        int divider = 0;
        int n = x;
        while (n >0) {
            divider += n % 10;
            n /= 10;
        }
        
        return x % divider == 0;
    }
}