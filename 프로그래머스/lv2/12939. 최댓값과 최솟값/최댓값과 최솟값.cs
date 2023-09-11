using System;

public class Solution {
    public string solution(string s) {
        string[] strings = s.Split(' ');
        int[] ints = Array.ConvertAll(strings, Convert.ToInt32);
        Array.Sort(ints);
        
        return $"{ints[0]} {ints[ints.Length - 1]}";
    }
}