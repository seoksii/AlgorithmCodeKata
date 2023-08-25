using System.Text;

public class Solution {
    public string solution(int n) {
        
        return new StringBuilder(n)
            .Insert(0, "수박", n / 2)
            .Insert(n-1, (n % 2 == 0 ? "" : "수"))
            .ToString();
    }
}