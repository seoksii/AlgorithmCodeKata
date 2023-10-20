using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(int[] numbers) {
        string[] stringArray = numbers.Select(x => x.ToString()).ToArray();
        Array.Sort(stringArray, (a, b) => {
            string longA = String.Concat(Enumerable.Repeat(a, 4)).Substring(0, 4);
            string longB = String.Concat(Enumerable.Repeat(b, 4)).Substring(0, 4);
            return String.Compare(longA,longB) > 0 ? -1 : 1;
        });
        StringBuilder answer = new StringBuilder();
        
        foreach(string s in stringArray)
            answer.Append(s);
        if (answer[0] == '0') return "0";
        return answer.ToString();
    }
}