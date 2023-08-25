using System;
using System.Linq;

public class Solution {
    public string solution(string phone_number) {
        return String.Concat(Enumerable.Repeat("*", phone_number.Length - 4)) + phone_number.Substring(phone_number.Length - 4);
    }
}