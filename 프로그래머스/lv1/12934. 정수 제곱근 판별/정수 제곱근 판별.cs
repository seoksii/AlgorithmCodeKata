public class Solution {
    public long solution(long n) {
        long k = 1;
        while (k * k < n)
            ++k;
        if (k * k == n) return n + 2 * k + 1;
        return (long)-1;
    }
}