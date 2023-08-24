public class Solution {
    public string solution(int num) {
        if (num == 0) return "Even";
        else if (num < 0) num *= -1;
        
        if (num % 2 == 0) return "Even";
        else // num % 2 != 0
            return "Odd";
    }
}