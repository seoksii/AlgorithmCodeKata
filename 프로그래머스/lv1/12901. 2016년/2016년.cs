public class Solution {
    public string solution(int a, int b) {
        string[] weekdays = new string[7] {"THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED"};
        int[] days = new int[12] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        int answer = b;
        for (int i = 0; i < a - 1; ++i)
            answer += days[i];
        
        return weekdays[answer % 7];
    }
}