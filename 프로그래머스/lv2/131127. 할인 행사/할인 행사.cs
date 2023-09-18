using System;
using System.Collections.Generic;

public class Solution {
    Dictionary<string, int> strToInt = new Dictionary<string, int>();
    
    public bool check(int[] number, string[] subDiscount) {
        foreach(string s in subDiscount)
            if (strToInt.ContainsKey(s)) --number[strToInt[s]];
        foreach (int n in number)
            if (n > 0) return false;
        return true;
    }
    
    public int solution(string[] want, int[] number, string[] discount) {
        int cnt = 0;
        int answer = 0;
        foreach (string s in want)
            strToInt.Add(s, cnt++);
        for (int i = 0; i <= discount.Length - 10; ++i) {
            int[] copiedNumber = new int[10];
            string[] subDiscount = new string[10];
            number.CopyTo(copiedNumber, 0);
            Array.Copy(discount, i, subDiscount, 0, 10);
            if (check(copiedNumber, subDiscount)) ++answer;
        }
            
        return answer;
    }
}