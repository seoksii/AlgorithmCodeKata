using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int length = numbers.Length;
        int[] answer = new int[length];
        int minMinus = length - 1;
        
        for (int i = length - 1; i >= 0; i--) {
            answer[i] = -1;
            if (numbers[i] > numbers[minMinus]) {
                minMinus = i;
                continue;
            }
            for (int j = i + 1; j < length; j++)
                if (numbers[i] < numbers[j]){
                    answer[i] = numbers[j];
                    break;
                }
                else if (numbers[i] > numbers[j] && numbers[j] != -1) {
                    if (numbers[i] < answer[j]) {
                        answer[i] = answer[j];
                        break;
                    }
                }
                else {
                    answer[i] = answer[j];
                    if (answer[i] == -1) minMinus = i;
                    break;
                }
        }
            
        
        return answer;
    }
}