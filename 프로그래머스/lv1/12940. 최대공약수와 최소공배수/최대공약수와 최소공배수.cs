public class Solution {
    public int[] solution(int n, int m) {
        if (n == m) return new int[] {n, n};
        int min = n < m ? n : m;
        int max = n > m ? n : m;
        
        if (max % min == 0) return new int[] {min, max};
        
        int mod = 0;
        while (min != 0) {
            mod = max % min;
            max = min;
            min = mod;
        }
        
        return new int[] {max, n * m / max};
    }
}