using System;

public class Solution {
    public bool check(string b) {
        string[] available = new string[4] {"aya", "ye", "woo", "ma"};
        string previousString = "";
        while (b.Length > 0) {
            bool isFail = true;
            foreach (string a in available) {
                if (b.Length < a.Length) continue;
                string c = b.Substring(0, a.Length);
                if (c == a) {
                    if (c == previousString) return false;
                    b = b.Substring(a.Length);
                    previousString = a;
                    isFail = false;
                    break;
                }
            }
            if (isFail) return false;
        }
        return true;
    }
    
    public int solution(string[] babbling) {
        string[] available = new string[4] {"aya", "ye", "woo", "ma"};
        int answer = 0;
        foreach (string b in babbling)
            if (check(b) == true) ++answer;
        return answer;
    }
}