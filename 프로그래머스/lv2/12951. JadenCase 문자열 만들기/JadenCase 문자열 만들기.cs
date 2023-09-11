using System.Text;

public class Solution {
    public string solution(string s) {
        bool isFirst = true;
        StringBuilder answer = new StringBuilder();
        foreach (char c in s)
            if (c == ' ') {
                isFirst = true;
                answer.Append(c);
            }
            else if (isFirst) {
                answer.Append(char.ToUpper(c));
                isFirst = false;
            }
            else
                answer.Append(char.ToLower(c));
        
        return answer.ToString();
    }
}