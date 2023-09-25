using System;
using System.Text;

public class Solution {
    bool isPrime(long num) {
        if (num == 1) return false;
        for (long i = 2; i * i <= num; ++i)
            if (num % i == 0) return false;
        return true;
    }
    
    public int solution(int n, int k) {
        StringBuilder sb = new StringBuilder();
        while (n > 0) {
            sb.Insert(0, n % k);
            n /= k;
        }
        string[] splitted = sb.ToString().Split('0');
        
        int answer = 0;
        Console.WriteLine(sb.ToString());
        foreach(string s in splitted)
            if (long.TryParse(s, out long num))
                if (isPrime(num))
                    ++answer;
        
        return answer;
    }
}