using System;

public class Solution {
    public string[] solution(string[] strings, int n)
    {
        Array.Sort(strings, (a, b) => {
            if (a[n] < b[n]) return -1;
            else if (a[n] > b[n]) return 1;
            else
                if (String.Compare(a, b) < 0) return -1;
                else if (String.Compare(a, b) > 0) return 1;
                else return 0;
        });

        return strings;
    }
}